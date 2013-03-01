using System;
using System.Collections.Generic;
using System.Text;

namespace SServer.Packets
{
    public class GameStateEnd : SSPacket
    {
        public GameStateEnd()
        {
            EndAddByte(9);
            StartAddInt16((short)(_data.Count + 2));
        }
    }

}
