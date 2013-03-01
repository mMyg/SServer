using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using SServer.IO;

namespace SServer.Packets
{
    public class SSPacket : Bytes
    {
        protected Int16 _length;
        protected Byte _id;
        private Byte[] _originaldata;

        public SSPacket()
        {
        }

        public SSPacket(Byte[] Data)
            : base(Data)
        {
            _originaldata = Data;
            _length = System.Net.IPAddress.NetworkToHostOrder(StartRemoveInt16());
            _id = StartRemoveByte();
        }

        public Int16 GetPacketLength()
        {
            return _length;
        }

        public Byte GetPacketId()
        {
            return _id;
        }

        public Byte[] GetBytes()
        {
            Byte[] returnbytes = new Byte[_data.Count];
            _data.CopyTo(returnbytes, 0);
            return returnbytes;
        }

        public Byte[] GetOriginalData()
        {
            return _originaldata;
        }
    }

}
