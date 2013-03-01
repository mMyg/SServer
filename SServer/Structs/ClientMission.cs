using System;
using System.Collections.Generic;
using System.Text;

namespace SServer.Structs
{
    public struct ClientMission
    {
        public Byte _type;
        public Byte _numofmessages;
        public Int32 _senderunitid;
        public ClientMessage _message;

        public ClientMission(Byte[] Data)
        {
            _type = Data[14];
            if (_type == 2)
            {
                _numofmessages = Data[15];
                _senderunitid = BitConverter.ToInt32(Data, 16);
                _message = new ClientMessage(Data);
            }
            else
            {
                _numofmessages = 0;
                _senderunitid = BitConverter.ToInt32(Data, 15);
                _message = new ClientMessage();
            }
        }
    }
}
