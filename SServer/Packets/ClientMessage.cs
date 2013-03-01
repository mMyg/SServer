using System;
using System.Collections.Generic;
using System.Text;

namespace SServer.Packets
{
    public class ClientChatMessage : SSPacket
    {
        private Byte _sourceid;
        private Byte _destinationid;
        private Int32 _destinationteam;
        private String _message;

        public ClientChatMessage(Byte[] Data)
            : base(Data)
        {
            _sourceid = StartRemoveByte();
            _destinationid = StartRemoveByte();
            _destinationteam = StartRemoveInt32();
            _message = StartRemoveString(_length - 10);
        }

        public Byte GetSourceId()
        {
            return _sourceid;
        }

        public Byte GetDestinationId()
        {
            return _destinationid;
        }

        public Int32 GetDestinationTeam()
        {
            return _destinationteam;
        }

        public String GetMessage()
        {
            return _message;
        }
    }
}
