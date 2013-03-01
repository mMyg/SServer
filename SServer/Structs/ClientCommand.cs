using System;
using System.Collections.Generic;
using System.Text;

namespace SServer.Structs
{
    public struct ClientCommand
    {
        public Int32 _length;
        public Byte _unknown1;
        public Byte _senderunitslot;
        public Byte _unknown2;
        public Int32 _unknown3;
        public ClientMission _mission;

        public ClientCommand(Byte[] Data)
        {
            _length = BitConverter.ToInt32(Data, 3);
            _unknown1 = Data[7];
            _senderunitslot = Data[8];
            _unknown2 = Data[9];
            _unknown3 = BitConverter.ToInt32(Data, 10);
            if (_length == 7)
            {
                _mission = new ClientMission();
            }
            else
            {
                _mission = new ClientMission(Data);
            }
        }
    }
}
