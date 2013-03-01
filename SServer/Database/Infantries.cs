using System;
using System.Collections.Generic;
using System.Text;
using SServer.Objects;

namespace SServer.Database
{
    public class Infantries
    {
        private List<Infantry> _infantries;

        public Infantries()
        {
            _infantries = new List<Infantry>();
            _infantries.Add(new Infantry(11, -1, 3, 11, 1, 100, 3, 125, -1, 0, 0, 0, 0, 0, 1, "E1", 101, 0));
            _infantries.Add(new Infantry(21, -1, 8, 9, 3, 160, 4, 135, -1, 0, 0, 0, 0, 0, 1, "E2", 102, 1));
            _infantries.Add(new Infantry(9, -1, 4, 11, 3, 300, 3, 100, -1, 0, 0, 0, 0, 0, 2, "E3", 103, 2));
            _infantries.Add(new Infantry(15, -1, 5, 10, 5, 200, 5, 190, -1, 0, 0, 0, 0, 0, 1, "E4", 104, 3));
            _infantries.Add(new Infantry(27, -1, 7, 10, 99, 300, 5, 200, -1, 0, 1, 0, 0, 2097152, 7, "E5", 105, 4));
            _infantries.Add(new Infantry(11, -1, -1, 11, 2, 500, 3, 25, -1, 1, 0, 0, 0, 0, 3, "E6", 546, 5));
            _infantries.Add(new Infantry(13, -1, 0, 11, 98, 1000, 5, 150, -1, 1, 0, 0, 0, 2097152, 7, "RMBO", 106, 6));
            _infantries.Add(new Infantry(13, -1, 2, 15, 99, 10, 0, 25, 10, 0, 1, 1, 1, 0, 99, "C1", 200, 7));
            _infantries.Add(new Infantry(13, -1, -1, 15, 99, 20, 0, 5, 0, 0, 1, 1, 1, 0, 99, "C2", 201, 8));
            _infantries.Add(new Infantry(13, -1, -1, 15, 99, 10, 0, 5, 0, 0, 1, 1, 1, 0, 99, "C3", 202, 9));
            _infantries.Add(new Infantry(13, -1, -1, 15, 99, 10, 0, 5, 0, 0, 0, 1, 1, 0, 99, "C4", 203, 10));
            _infantries.Add(new Infantry(13, -1, -1, 15, 99, 10, 0, 5, 0, 0, 1, 1, 1, 0, 99, "C5", 204, 11));
            _infantries.Add(new Infantry(13, -1, -1, 15, 99, 10, 0, 5, 0, 0, 1, 1, 1, 0, 99, "C6", 205, 12));
            _infantries.Add(new Infantry(13, -1, 2, 15, 99, 10, 0, 5, 10, 0, 1, 1, 1, 0, 99, "C7", 206, 13));
            _infantries.Add(new Infantry(13, -1, -1, 15, 99, 10, 0, 5, 0, 0, 1, 1, 1, 0, 99, "C8", 207, 14));
            _infantries.Add(new Infantry(13, -1, -1, 15, 99, 10, 0, 5, 0, 0, 1, 1, 1, 0, 99, "C9", 208, 15));
            _infantries.Add(new Infantry(13, -1, -1, 15, 99, 10, 0, 50, 0, 0, 1, 1, 1, 0, 99, "C10", 577, 16));
            _infantries.Add(new Infantry(13, -1, -1, 15, 99, 10, 0, 50, 0, 0, 1, 1, 1, 0, 99, "MOEBIUS", 209, 17));
            _infantries.Add( new Infantry(13, -1, 2, 13, 99, 10, 0, 25, 10, 0, 1, 1, 1, 0, 99, "DELHPI", 589, 18));
            _infantries.Add(new Infantry(13, -1, -1, 13, 99, 10, 0, 25, 10, 0, 1, 1, 1, 0, 99, "CHAN", 606, 19));
        }

        public Infantry Get(String Name)
        {
            for (Int32 i = 0; i < _infantries.Count; i++)
            {
                if (_infantries[i]._namestring.ToLower() == Name.ToLower())
                {
                    return _infantries[i];
                }
            }
            return null;
        }

        public Infantry Get(Int32 NameStringId)
        {
            for (Int32 i = 0; i < _infantries.Count; i++)
            {
                if (_infantries[i]._namestringid == NameStringId)
                {
                    return _infantries[i];
                }
            }
            return null;
        }

        public Infantry Get(Byte UnitType)
        {
            for (Int32 i = 0; i < _infantries.Count; i++)
            {
                Byte tempUnitId = (Byte)_infantries[i]._unitid;
                if (tempUnitId == UnitType)
                {
                    return _infantries[i];
                }
            }
            return null;
        }
    }
}
