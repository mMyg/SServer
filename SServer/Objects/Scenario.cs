using System;
using System.Collections.Generic;
using System.Text;
using SServer.IO;
using SServer.Enums;
using SServer.Structs;
using SServer.Interfaces;

namespace SServer.Objects
{
    public class Scenario
    {
        public Int32 _basic_percent;
        public Int32 _basic_carrovercap;
        public Int32 _basic_carryovermoney;
        public Int32 _basic_buildlevel;
        public String _basic_theme;
        public String _basic_player;
        public String _basic_action;
        public String _basic_lose;
        public String _basic_win;
        public String _basic_brief;
        public String _basic_intro;
        public String _basic_name;

        public Int32 _map_version;
        public Int32 _map_height;
        public Int32 _map_width;
        public Int32 _map_x;
        public Int32 _map_y;
        public String _map_theatre;

        public Waypoint[] _waypoints;

        public Int32 _crates_ionFactor;
        public Int32 _crates_density;
        public Int32 _crates_armageddon;
        public Int32 _crates_radar;
        public Int32 _crates_unshroud;
        public Int32 _crates_reshroud;
        public Int32 _crates_uncloakall;
        public Int32 _crates_kill;
        public Int32 _crates_teleport;
        public Int32 _crates_stealth;
        public Int32 _crates_bomb;
        public Int32 _crates_heal;
        public Int32 _crates_addrange;
        public Int32 _crates_rapidreload;
        public Int32 _crates_addspeed;
        public Int32 _crates_addweapon;
        public Int32 _crates_addstrength;

        public Int32 _base_count;

        public Overlay[] _overlay;

        public Terrain[] _terrain;

        public Template[] _templates;

        public Int32 _scenarionumber;

        public Scenario(String Name, Byte[] IniFile, Byte[] BinFile)
        {
            try
            {
                _scenarionumber = Int32.Parse(Name.Substring(3, 2));
                IniFile tempIniFile = new IniFile(IniFile);
                IniFile.Section tempSection = tempIniFile.GetSection("[Basic]");
                _basic_percent = Int32.Parse(tempSection.GetPropertyByName("Percent").GetValue()[0]);
                _basic_carrovercap = Int32.Parse(tempSection.GetPropertyByName("CarryOverCap").GetValue()[0]);
                _basic_carryovermoney = Int32.Parse(tempSection.GetPropertyByName("CarryOverMoney").GetValue()[0]);
                _basic_buildlevel = Int32.Parse(tempSection.GetPropertyByName("BuildLevel").GetValue()[0]);
                _basic_theme = tempSection.GetPropertyByName("Theme").GetValue()[0].Trim();
                _basic_player = tempSection.GetPropertyByName("Player").GetValue()[0].Trim();
                _basic_action = tempSection.GetPropertyByName("Action").GetValue()[0].Trim();
                _basic_lose = tempSection.GetPropertyByName("Lose").GetValue()[0].Trim();
                _basic_win = tempSection.GetPropertyByName("Win").GetValue()[0].Trim();
                _basic_brief = tempSection.GetPropertyByName("Brief").GetValue()[0].Trim();
                _basic_intro = tempSection.GetPropertyByName("Intro").GetValue()[0].Trim();
                if (tempSection.GetPropertyByName("Name") != null)
                {
                    _basic_name = tempSection.GetPropertyByName("Name").GetValue()[0].Trim();
                }
                tempSection = tempIniFile.GetSection("[Map]");
                _map_version = Int32.Parse(tempSection.GetPropertyByName("Version").GetValue()[0]);
                _map_height = Int32.Parse(tempSection.GetPropertyByName("Height").GetValue()[0]);
                _map_width = Int32.Parse(tempSection.GetPropertyByName("Width").GetValue()[0]);
                _map_x = Int32.Parse(tempSection.GetPropertyByName("x").GetValue()[0]);
                _map_y = Int32.Parse(tempSection.GetPropertyByName("y").GetValue()[0]);
                _map_theatre = tempSection.GetPropertyByName("Theater").GetValue()[0].Trim();
                tempSection = tempIniFile.GetSection("[Waypoints]");
                _waypoints = new Waypoint[tempSection.GetProperties().Count];
                for (int i = 0; i < tempSection.GetProperties().Count; i++)
                {
                    _waypoints[i] = new Waypoint(Int32.Parse(tempSection.GetProperties()[i].GetName()),
                                        Int16.Parse(tempSection.GetProperties()[i].GetValue()[0]));
                }
                tempSection = tempIniFile.GetSection("[Crates]");
                _crates_ionFactor = Int32.Parse(tempSection.GetPropertyByName("IonFactor").GetValue()[0]);
                _crates_density = Int32.Parse(tempSection.GetPropertyByName("Density").GetValue()[0]);
                _crates_armageddon = Int32.Parse(tempSection.GetPropertyByName("Armageddon").GetValue()[0]);
                _crates_radar = Int32.Parse(tempSection.GetPropertyByName("Radar").GetValue()[0]);
                _crates_unshroud = Int32.Parse(tempSection.GetPropertyByName("Unshroud").GetValue()[0]);
                _crates_reshroud = Int32.Parse(tempSection.GetPropertyByName("Reshroud").GetValue()[0]);
                _crates_uncloakall = Int32.Parse(tempSection.GetPropertyByName("Uncloakall").GetValue()[0]);
                _crates_kill = Int32.Parse(tempSection.GetPropertyByName("Kill").GetValue()[0]);
                _crates_teleport = Int32.Parse(tempSection.GetPropertyByName("Teleport").GetValue()[0]);
                _crates_stealth = Int32.Parse(tempSection.GetPropertyByName("Stealth").GetValue()[0]);
                _crates_bomb = Int32.Parse(tempSection.GetPropertyByName("Bomb").GetValue()[0]);
                _crates_heal = Int32.Parse(tempSection.GetPropertyByName("Heal").GetValue()[0]);
                _crates_addrange = Int32.Parse(tempSection.GetPropertyByName("AddRange").GetValue()[0]);
                _crates_rapidreload = Int32.Parse(tempSection.GetPropertyByName("RapidReload").GetValue()[0]);
                _crates_addspeed = Int32.Parse(tempSection.GetPropertyByName("AddSpeed").GetValue()[0]);
                _crates_addweapon = Int32.Parse(tempSection.GetPropertyByName("AddWeapon").GetValue()[0]);
                _crates_addstrength = Int32.Parse(tempSection.GetPropertyByName("AddStrength").GetValue()[0]);
                tempSection = tempIniFile.GetSection("[Base]");
                _base_count = Int32.Parse(tempSection.GetPropertyByName("Count").GetValue()[0]);
                tempSection = tempIniFile.GetSection("[OVERLAY]");
                _overlay = new Overlay[tempSection.GetProperties().Count];
                for (Int32 i = 0; i < _overlay.Length; i++)
                {
                    _overlay[i] = new Overlay(Int16.Parse(tempSection.GetProperties()[i].GetName()),
                                            tempSection.GetProperties()[i].GetValue()[0].Trim());
                }
                tempSection = tempIniFile.GetSection("[TERRAIN]");
                _terrain = new Terrain[tempSection.GetProperties().Count];
                for (Int32 i = 0; i < _terrain.Length; i++)
                {
                    _terrain[i] = new Terrain(Int16.Parse(tempSection.GetProperties()[i].GetName()),
                                            tempSection.GetProperties()[i].GetValue()[0].Trim(),
                                            tempSection.GetProperties()[i].GetValue()[1].Trim());
                }
                _templates = new Template[BinFile.Length/4];
                for (Int32 i = 0; i < BinFile.Length; i++)
                {
                    if (i % 4 == 0)
                    {
                        Int16 templateindex = BitConverter.ToInt16(BinFile, i);
                        Byte templateid = BinFile[i + 2];
                        Byte templatetile = BinFile[i + 3];
                        _templates[i/4] = new Template(templateindex, templateid, templatetile);
                    }
                }              
            }
            catch (Exception e)
            { Console.WriteLine(e);}
        }
    }
}
