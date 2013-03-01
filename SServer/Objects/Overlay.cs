using System;
using System.Collections.Generic;
using System.Text;

namespace SServer.Objects
{
    public class Overlay
    {
        private Int16 _index;
        private String _type;

        public Overlay(Int16 Index, String Type)
        {
            _index = Index;
            _type = Type;
        }

        public Int16 GetIndex()
        {
            return _index;
        }

        public new String GetType()
        {
            return _type;
        }
    }
}
