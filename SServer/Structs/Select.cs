using System;
using System.Collections.Generic;
using System.Text;

namespace SServer.Structs
{
    public struct Select
    {
        public static readonly Byte Type = 5;
        public Int32 _unitid;

        public Select(Int32 UnitId)
        {
            _unitid = UnitId;
        }
    }

}
