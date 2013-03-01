using System;
using System.Collections.Generic;
using System.Text;

namespace SServer.Structs
{
    public struct MoveTo
    {
        public static readonly Byte Type = 19;
        public Int32 _unitid;
        public Int16 _cellindex;
        public Byte _facing; // 0 N, 1 NE, 2 E, 3 SE, 4 S, etc..

        public MoveTo(Int32 UnitId, Int16 CellIndex, Byte Facing)
        {
            _unitid = UnitId;
            _cellindex = CellIndex;
            _facing = Facing;
        }
    }

}
