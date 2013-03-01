using System;
using System.Collections.Generic;
using System.Text;

namespace SServer.Packets
{
    public class GamePacketSix : SSPacket
    {
        public GamePacketSix(Int32 UnitId)
        {
            EndAddByte(6);
            EndAddInt32(UnitId);
            StartAddInt16((short)(_data.Count + 2));
        }
    }
}
