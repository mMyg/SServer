using System;
using System.Collections.Generic;
using System.Text;

namespace SServer.Structs
{
    public struct CratePickup
    {
        public static readonly Byte Type = 24;
        public Int32 _unitid;
        public Byte _uniquegameid;
        public Int16 _unknown1;
        public Byte _cratetype;
        public Int32 _cratevalue;

        public CratePickup(Int32 UnitId, Byte UniqueGameId, Int16 Unknown1, Byte CrateType, Int32 CrateValue)
        {
            _unitid = UnitId;
            _uniquegameid = UniqueGameId;
            _unknown1 = Unknown1;
            _cratetype = CrateType;
            _cratevalue = CrateValue;
        }
    }
}
