using System;
using System.Collections.Generic;
using System.Text;

namespace SServer.Objects
{
    public class Waypoint
    {
        private Int32 _number;
        private Int16 _index;

        public Waypoint(Int32 Number, Int16 Index)
        {
            _number = Number;
            _index = Index;
        }

        public Int32 GetNumber()
        {
            return _number;
        }

        public Int16 GetIndex()
        {
            return _index;
        }
    }
}
