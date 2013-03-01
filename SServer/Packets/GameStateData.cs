using System;
using System.Collections.Generic;
using System.Text;
using SServer.Objects;

namespace SServer.Packets
{
    public class GameStateData : SSPacket
    {
        public GameStateData(List<Unit> Units)
        {
            EndAddByte(8);
            EndAddInt32(Units.Count * 18);
            for (Int32 i = 0; i < Units.Count; i++)
            {
                EndAddInt32(Units[i].GetUnitId()); // Unit Id
                EndAddInt32(Units[i].GetCell().GetPosition1()); // Unit coordinates
                EndAddInt16(Units[i].GetStartingHealth()); // Starting HP (If me) // Otherwise, current HP
                EndAddByte(Units[i].GetHouse()); // Unit House
                EndAddByte(Units[i].GetType()); // Unit type
                EndAddByte(Units[i].GetStealth()); // Stealth enabled
                EndAddByte(Units[i].GetArmour()); // Current armour upgrade
                EndAddByte(Units[i].GetSpeed()); // Current speed upgrade
                EndAddByte(Units[i].GetFirePower()); // Current Firepower upgrade
                EndAddByte(Units[i].GetReload()); // Current reload upgrade
                EndAddByte(Units[i].GetRange()); // Current Range upgrade
            }
            StartAddInt16((short)(_data.Count + 2));
        }
    }

}
