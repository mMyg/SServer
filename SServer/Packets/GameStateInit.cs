using System;
using System.Collections.Generic;
using System.Text;
using SServer.Objects;

namespace SServer.Packets
{
    public class GameStateInit : SSPacket
    {
        public GameStateInit(Int32 UnitCount)
        {
            EndAddByte(7);
            EndAddInt32(UnitCount * 18);
            StartAddInt16((short)(_data.Count + 2));
        }
    }

}
