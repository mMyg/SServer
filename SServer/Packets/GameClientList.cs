using System;
using System.Collections.Generic;
using System.Text;
using SServer.Objects;

namespace SServer.Packets
{
    public class GameClientList : SSPacket
    {
        public GameClientList(List<Unit> Units)
        {
            EndAddByte(10);
            EndAddByte((Byte)Units.Count);
            for (Int32 i = 0; i < Units.Count; i++)
            {
                EndAddString(Units[i].GetName().Substring(0, 11));
                EndAddByte(0);  // ? 
                EndAddByte(Units[i].GetHouse());  // Side icon (same as side)
                EndAddByte(Units[i].GetUnitSlot());  // Uniquegame id
                EndAddInt32(Units[i].GetUnitId()); // ? 
                EndAddByte((Byte)(Units[i].GetTeam())); // Team (name colour as well, side -4)
                EndAddInt32(Units[i].GetScore()); // Score
                EndAddInt32(0); // ? 
                EndAddByte(0); // Spectator Boolean
                EndAddInt32(0); // Not unitid, would give error if it was wrong (has flag?)
                EndAddInt16(1715); // Team Base Cell index
            }
            StartAddInt16((short)(_data.Count + 2));
        }
    }
}
