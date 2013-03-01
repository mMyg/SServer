using System;
using System.Collections.Generic;
using System.Text;

namespace SServer.Objects
{
    // Todo, database of terrain items
    public class Terrain
    {
        private Int16 _index;
        private String _type;
        private String _info;

        public Terrain(Int16 Index, String Type, String Info)
        {
            _index = Index;
            _type = Type;
            _info = Info;
        }

        public Int16 GetIndex()
        {
            return _index;
        }

        public new String GetType()
        {
            return _type;
        }

        public String GetInfo()
        {
            return _info;
        }
    }
}
