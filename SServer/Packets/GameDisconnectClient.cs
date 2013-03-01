using System;
using System.Collections.Generic;
using System.Text;
using SServer.Objects;

namespace SServer.Packets
{
    public class GameDisconnectPlayer : SSPacket
    {
        public GameDisconnectPlayer(Unit Unit)
        {
            EndAddByte(2);
            EndAddByte((Byte)Unit.GetUnitSlot());
            StartAddInt16((short)(_data.Count + 2));
        }
    }

}
