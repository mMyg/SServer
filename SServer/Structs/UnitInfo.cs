using System;
using System.Collections.Generic;
using System.Text;

namespace SServer.Structs
{
    public struct UnitInfo
    {
        public static readonly Byte Type = 11;
        public Byte _visible;
        public Int32 _unitid;
        public Int32 _position;
        public Byte _unitslot;
        public Byte _unknown;
        public Byte _unittype;
        public Byte _armour;
        public Byte _speed;
        public Byte _firepower;
        public Byte _reload;
        public Byte _range;

        public UnitInfo(Byte Visible, Int32 UnitId, Int32 Position, Byte UnitSlot, Byte Unknown, Byte UnitType, Byte Armour, Byte Speed, Byte FirePower,
            Byte Reload, Byte Range)
        {
            _visible = Visible;
            _unitid = UnitId;
            _position = Position;
            _unitslot = UnitSlot;
            _unknown = Unknown;
            _unittype = UnitType;
            _armour = Armour;
            _speed = Speed;
            _firepower = FirePower;
            _reload = Reload;
            _range = Range;
        }
    }
}
