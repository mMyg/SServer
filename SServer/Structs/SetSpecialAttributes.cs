using System;
using System.Collections.Generic;
using System.Text;

namespace SServer.Structs
{
    public struct SetSpecialAttributes
    {
        public static readonly Byte Type = 25;
        public Int32 _unitid;
        public Byte _stealth;
        public Byte _inv;

        public SetSpecialAttributes(Int32 UnitId, Byte Stealth, Byte Inv)
        {
            _unitid = UnitId;
            _stealth = Stealth;
            _inv = Inv;
        }
    }
}
