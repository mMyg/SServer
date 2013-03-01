using System;
using System.Collections.Generic;
using System.Text;

namespace SServer.Objects
{
    public class Template
    {
        private Int16 _index;
        private Byte _id;
        private Byte _tile;

        public Template(Int16 Index, Byte Id, Byte Tile)
        {
            _index = Index;
            _id = Id;
            _tile = Tile;
        }

        public Int16 GetIndex()
        {
            return _index;
        }

        public Byte GetId()
        {
            return _id;
        }

        public Byte GetTile()
        {
            return _tile;
        }
    }
}
