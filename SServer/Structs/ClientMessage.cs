using System;
using System.Collections.Generic;
using System.Text;

namespace SServer.Structs
{
    public struct ClientMessage
    {
        // Always 13 bytes
        public Byte _type;
        public Int32 _target1;
        public Int32 _target2;
        public Int32 _endcode;

        public ClientMessage(Byte[] Data)
        {
            _type = Data[20];
            _target1 = BitConverter.ToInt32(Data, 21);
            _target2 = BitConverter.ToInt32(Data, 24);
            _endcode = BitConverter.ToInt32(Data, 29);
        }
    }

}
