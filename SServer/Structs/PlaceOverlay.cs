using System;
using System.Collections.Generic;
using System.Text;

namespace SServer.Structs
{
    public struct PlaceOverlay
    {
        public static readonly Byte Type = 23;
        public Int16 _cellindex;
        public Byte _class;
        public Byte _type;

        public PlaceOverlay(Int16 CellIndex, Byte Class, Byte Type)
        {
            _cellindex = CellIndex;
            _class = Class;
            _type = Type;
        }
    }
}
