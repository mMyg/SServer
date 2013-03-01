using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using SServer.IO;
using SServer.Packets;
using SServer.Interfaces;

namespace SServer.Objects
{
    public class Server
    {
        private Boolean _running;
        private Thread _accept;
        private Game _game;

        public Server()
        {
            Console.WriteLine("===========Sole Survivor Server===========");
            Console.WriteLine("Creating Server Socket!");
            Socket ServerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp); 
            Console.WriteLine("Binding Socket to " + Environment.Variables.SERVER_PORT);
            ServerSocket.Bind(new IPEndPoint(IPAddress.Any, Environment.Variables.SERVER_PORT));
            Console.WriteLine("Starting Listen with " + Environment.Variables.QUEUE_LENGTH);
            ServerSocket.Listen(Environment.Variables.QUEUE_LENGTH);
            Console.WriteLine("Creating game object");
            _game = new Game();
            Console.WriteLine("Starting Server Thread!");
            _running = true;
            _accept = new Thread(new ParameterizedThreadStart(run));
            _accept.Start(ServerSocket);


            // ADMIN COMMAND TEST
            // TODO: IMPLEMENT PROPER ADMIN PROTOCOL
            _game.ReceiveQueue.Enqueue(new Byte[] { 0, 0, 254 });
            // END TEST
        }

        private void run(Object O)
        {
            try
            {
                List<Socket> clients = new List<Socket>();
                List<Socket> recvlist = new List<Socket>();
                Socket ThreadSocket = (Socket)O;
                Byte[] localbuffer = new Byte[Environment.Variables.BUFFER_SIZE];
                while (_running)
                {
                    recvlist = new List<Socket>(clients);
                    recvlist.Add(ThreadSocket);
                    Socket.Select(recvlist, null, null, 1000);
                    for (Int32 i = 0; i < recvlist.Count; i++)
                    {
                        if (recvlist[i] == ThreadSocket)
                        {
                            Socket clientsocket = recvlist[i].Accept();
                            clients.Add(clientsocket);
                        }
                        else
                        {
                            Int32 receivedint = recvlist[i].Receive(localbuffer);
                            if (receivedint == 0)
                            {
                                recvlist[i].Disconnect(true);
                                recvlist.RemoveAt(i);
                            }
                            else
                            {
                                Int16 packetlength = IPAddress.NetworkToHostOrder(BitConverter.ToInt16(localbuffer, 0));
                                Byte[] packetdata = new Byte[packetlength];
                                for (Int16 j = 0; j < packetlength; j++)
                                {
                                    packetdata[j] = localbuffer[j];
                                }
                                _game.ReceiveQueue.Enqueue(packetdata);
                            }
                        }
                    }
                    if (_game.SendQueue.HasItems())
                    {
                        Byte[] sendingdata = _game.SendQueue.Dequeue();
                        for (Int32 i = 0; i < clients.Count; i++)
                        {
                            clients[i].Send(sendingdata);
                        }
                    }
                    Thread.Sleep((Int32)Enums.ServerPriority.High);
                }
            }
            catch (Exception e)
            {Console.WriteLine(e);}
        }
    }
}
