using System;
using System.Collections.Generic;
using System.Text;
using SServer.Objects;

namespace SServer.Packets
{
    public class GameClientStatus : SSPacket
    {
        public GameClientStatus(List<Unit> Units)
        {
            EndAddByte(11);
            EndAddByte((Byte)Units.Count);
            for (Int32 i = 0; i < Units.Count; i++)
            {
                EndAddByte(0); // Is not visible (probably used to save bandwidth)
                EndAddInt32(Units[i].GetUnitId()); // Unit Id 
                EndAddInt32(Units[i].GetCell().GetPosition2()); // Unit coordinates
                EndAddByte(Units[i].GetUnitSlot()); // My unique id
                EndAddByte(0); // ?
                EndAddByte(Units[i].GetType()); // Unit Type
                EndAddByte(Units[i].GetArmour()); // Armour upgrade
                EndAddByte(Units[i].GetSpeed()); // Speed Upgrade
                EndAddByte(Units[i].GetFirePower()); // FirePower upgrade
                EndAddByte(Units[i].GetReload()); // Reload upgrade
                EndAddByte(Units[i].GetRange()); // Range upgrade
            }
            StartAddInt16((short)(_data.Count + 2));
        }
    }
        
}
