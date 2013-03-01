using System;
using System.Collections.Generic;
using System.Text;

namespace SServer.Structs
{
    public struct SlotInfo
    {
        public static readonly Byte Type = 10;
        public String _name;
        public Byte _magicnumber;
        public Byte _house;
        public Byte _unitslot;
        public Int32 _unknown1;
        public Byte _team;
        public Int32 _score;
        public Int32 _unknown2;
        public Byte _spectator;
        public Int32 _unknown3;
        public Int16 _flaglocation;

        public SlotInfo(String Name, Byte MagicNumber, Byte House, Byte UnitSlot, Int32 Unknown1, Byte Team, Int32 Score, Int32 unknown2, Byte Spectator,
            Int32 Unknown3, Int16 Flaglocation)
        {
            _name = Name;
            _magicnumber = MagicNumber;
            _house = House;
            _unitslot = UnitSlot;
            _unknown1 = Unknown1;
            _team = Team;
            _score = Score;
            _unknown2 = unknown2;
            _spectator = Spectator;
            _unknown3 = Unknown3;
            _flaglocation = Flaglocation;
        }
    }
}
