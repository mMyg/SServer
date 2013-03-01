using System;
using System.Collections.Generic;
using System.Text;

namespace SServer.Structs
{
    public struct UnitFacing
    {
        public static readonly Byte Type = 22;
        public Int32 _unitid;
        public Byte _direction;

        public UnitFacing(Int32 UnitId, Byte Direction)
        {
            _unitid = UnitId;
            _direction = Direction;
        }
    }
}
