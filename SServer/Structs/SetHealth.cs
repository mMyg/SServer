using System;
using System.Collections.Generic;
using System.Text;

namespace SServer.Structs
{
    public struct SetHealth
    {
        public static readonly Byte Type = 12;
        public Int32 _unitid;
        public Int16 _health;

        public SetHealth(Int32 UnitId, Int16 Health)
        {
            _unitid = UnitId;
            _health = Health;
        }
    }
}
