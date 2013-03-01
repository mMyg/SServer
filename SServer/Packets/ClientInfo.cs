using System;
using System.Collections.Generic;
using System.Text;
using System.Net;

namespace SServer.Packets
{
    public class ClientInfo : SSPacket
    {
        private String _name; //length 11
        private Byte _magicnumber;
        private Byte _side;
        private Byte _class;
        private Int32 _type;
        private Int64 _majorversion;
        private Int32 _minorversion;

        public ClientInfo(Byte[] Data)
            : base(Data)
        {
            _name = StartRemoveString(11);
            _magicnumber = StartRemoveByte();
            _side = StartRemoveByte();
            _class = StartRemoveByte();
            _type = StartRemoveInt32();
            _majorversion = StartRemoveInt64();
            _minorversion = StartRemoveInt32();
        }

        public String GetName()
        {
            return _name;
        }

        public Byte GetMagicNumber()
        {
            return _magicnumber;
        }

        public Byte GetSide()
        {
            return _side;
        }

        public Byte GetClass()
        {
            return _class;
        }

        public new Int32 GetType()
        {
            return _type;
        }

        public Int64 GetMajorVersion()
        {
            return _majorversion;
        }

        public Int32 GetMinorVersion()
        {
            return _minorversion;
        }
    }

}
