using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Diagnostics;
using System.IO;
using System.Drawing;
using SServer.Objects;
using SServer.Interfaces;
using SServer.IO;
using SServer.Structs;
using SServer.Database;
using SServer.Packets;

namespace SServer.Objects
{
    public class Game
    {
        // Basic raw areas of the game that will be manipulated
        private Cell[] _celllayer;
        private Unit[] _unitslots;
        private Scenario _currentscenario;
        private Int32 _scenarioindex;
        private Int32 _gameticks;
        private Int32 _sessionticks;
        private Random _random;
        // Database/data entries/access items
        private Infantries _infantries;
        private Vehicles _vehicles;
        private Scenarios _scenarios;
        private MixFile _soledisk;
        private Settings _gamesettings;
        // Queue items and threads
        public NetworkQueue ReceiveQueue;
        public NetworkQueue SendQueue;
        private Thread _receivethread;
        // Engine booleans for control/sync
        private Boolean _running;
        private Boolean _started;

        public Game()
        {
            Console.WriteLine("+++++++++++++++++++");
            Console.WriteLine("Initilizing Game...");
            _gameticks = 0;
            _scenarioindex = -1;
            Console.WriteLine("Game Loading database info...");
            _infantries = new Infantries();
            _vehicles = new Vehicles();
            _scenarios = new Scenarios();
            _soledisk = new MixFile("SOLEDISK.MIX");
            _gamesettings = new Settings("Server.ini");
            Console.WriteLine("Game done Loading database info!");
            ReceiveQueue = new NetworkQueue(Environment.Variables.QUEUE_LENGTH);
            SendQueue = new NetworkQueue(Environment.Variables.QUEUE_LENGTH);
            _receivethread = new Thread(new ThreadStart(engineloop));
            _running = true;
            _started = false;
            Console.WriteLine("Starting game engine thread!");
            Console.WriteLine("+++++++++++++++++++");
            _receivethread.Start();
        }

        // Engine Thread/Loop
        private void engineloop()
        {
            try
            {
                Initilize();
                while (_running)
                {
                    if (_sessionticks % Environment.Variables.ENGINE_TICK_RATE == 0)
                    {
                        for (Int32 i = 0; i < ReceiveQueue.CurrentItems(); i++)
                        {
                            ProcessInput(_started, ReceiveQueue.Dequeue());
                        }
                        ProcessState();            
                    }
                    if (_started)
                    {
                        ProcessMisc();
                        ++_sessionticks;
                    }
                    ++_gameticks;
                    Thread.Sleep((Int32)Enums.ServerPriority.Immediate);
                }
            }
            catch (Exception e)
            { Console.WriteLine(e); }
        }

        // Process user input
        private void ProcessInput(Boolean Started, Byte[] B)
        {
            try
            {
                switch (B[2])
                {
                    // { 0,33,3,26,0,0,0,24,10,246,12,0,232,121,2,1,10,192,0,0,2,0,0,0,0,230,71,0,0,0,10,192,0 }
                    case 3:
                        if (Started)
                        {
                            Int32 playerdatalength = B[3];
                            Byte[] playerdata = new Byte[playerdatalength];
                            for (Int32 i = 0; i < playerdatalength; i++)
                            {
                                playerdata[i] = B[i+4];
                            }
                        }
                        break;
                    //  { 0,14,29,10,255,255,255,255,255,116,101,115,116,0 }
                    case 29:
                        Console.WriteLine("Chat");
                        break;
                    //  { 0,33,101,45,53,51,54,56,55,48,57,49,50,0,249,6,3,6,0,0,0,1,0,0,0,0,0,0,0,5,1,0,0 }
                    case 101:
                        Console.WriteLine("New Unit");
                        break;
                    case 254:
                        Console.WriteLine("Start game");
                        Start();
                        break;
                    case 255:
                        Console.WriteLine("Stop game");
                        Stop();
                        break;
                }
            }
            catch (Exception e)
            { Console.WriteLine(e); }
        }

        // Process state data
        private void ProcessState()
        {
            try
            {
                // Go through all cells + units on cells checking for possible events
                // Check for valid range (for shooting)
                // Check health changes
                // Check Crate pickups
                // Check Current path is not blocked
                // Check for teleports
                // Check for goals
                // Check Crate amounts
                // 
                // Check AI Stuffz?
            }
            catch (Exception e)
            { Console.WriteLine(e); }
        }

        // Process Misc
        private void ProcessMisc()
        {
            // Check if timelimit has been reached
            if (_sessionticks == _gamesettings.gameParms_TimeLimit)
            {
                // Re-initialize the game
                Initilize();
            }
            // Check if stats.out needs to be written
            if (_gamesettings.stats_ClientStats == 1 && _sessionticks % _gamesettings.stats_StatsInterval == 0)
            {
                // Write stats to stats file
                WriteStats();
            }
        }

        // Initilize the current game session
        public void Initilize()
        {
            try
            {
                // Reset cells
                _celllayer = new Cell[Environment.Variables.MAP_CELL_DIMENSION * Environment.Variables.MAP_CELL_DIMENSION];
                // Reset unit slots <--- Should I do this?
                _unitslots = new Unit[Environment.Variables.MAP_UNIT_SLOTS];
                // Reset current ticks
                _sessionticks = 0;
                // Reset random
                _random = new Random(Util_GetTime() % 3571);
                // Select map: Check for random mapping settings
                if (_gamesettings.gameparms_RandomMaps == 1)
                {
                    _scenarioindex = _random.Next(0, _scenarios.GetRecordCount() - 1);
                }
                else
                {
                    _scenarioindex++;
                }
                // Get map info
                String nextscenario = _scenarios.GetScenarioByIndex(_scenarioindex);
                String nextscenarioini = nextscenario + Environment.Variables.INI_FILE_EXTENSION;
                String nextscenariobin = nextscenario + Environment.Variables.BIN_FILE_EXTENSION;
                Byte[] inifile = _soledisk.GetFileByString(nextscenarioini);
                Byte[] binfile = _soledisk.GetFileByString(nextscenariobin);
                _currentscenario = new Scenario(nextscenario, inifile, binfile);
                // Load map info into cells
                for (Int16 i = 0; i < _celllayer.Length; i++)
                {
                    _celllayer[i] = new Cell(i);
                }
                // Templates
                for (Int32 i = 0; i < _currentscenario._templates.Length; i++)
                {
                    _celllayer[_currentscenario._templates[i].GetIndex()].SetTemplate(_currentscenario._templates[i]);
                }
                for (Int32 i = 0; i < _currentscenario._terrain.Length; i++)
                {
                    _celllayer[_currentscenario._terrain[i].GetIndex()].SetTerrain(_currentscenario._terrain[i]);
                }
            }
            catch (Exception e)
            { Console.WriteLine(e);}
        }

        // Process server stats and save
        private void WriteStats()
        {
            try
            {
                FileStream serverstatsfile;
                if (_gamesettings.stats_StatsAppend == 0)
                {
                    serverstatsfile = new FileStream(_gamesettings.stats_StatsFile.Trim(), FileMode.Create);
                }
                else
                {
                    serverstatsfile = new FileStream(_gamesettings.stats_StatsFile.Trim(), FileMode.Append);
                }
                StreamWriter statstream = new StreamWriter(serverstatsfile);
                statstream.WriteLine(Util_GetTime() + "-Test stats file");
                statstream.Close();
                serverstatsfile.Close();
            }
            catch (Exception e)
            { Console.WriteLine(e); }
        }

        // Stop the game session
        public void Stop()
        {
            _started = false;
        }

        // Start the game session 
        public void Start()
        {
            _started = true;
        }

        // Get the current time
        private Int32 Util_GetTime()
        {
            return (Int32)(DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds; 
        }

        // Convert Strings to Mix file Id's
       
    }
}
