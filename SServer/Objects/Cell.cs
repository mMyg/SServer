using System;
using System.Collections.Generic;
using System.Text;
using SServer.Enums;

namespace SServer.Objects
{
    public class Cell
    {
        private Byte _y;
        private Byte _x;
        private Int16 _index;
        private Theater _theatre;
        private Template _template;
        private Terrain _terrain;
        private Overlay _overlay;
        private Unit _unit;

        public Cell(Int16 Index)
        {
            _y = (Byte)(Index / 128);
            _x = (Byte)(Index - (_y * 128));
            _index = Index;
        }

        public Byte GetY()
        {
            return _y;
        }

        public Byte GetX()
        {
            return _x;
        }

        public Int16 GetIndex()
        {
            return _index;
        }

        public Int32 GetPosition1()
        {
            return (16777216 * _x) + (256 * _y);
        }

        public Int32 GetPosition2()
        {
            return 4194304 + (256 * _index);
        }

        public void SetTheatre(Theater Theater)
        {
            _theatre = Theater;
        }

        public void SetTemplate(Template Template)
        {
            _template = Template;
        }

        public void SetTerrain(Terrain Terrain)
        {
            _terrain = Terrain;
        }

        public void SetOverlay(Overlay Overlay)
        {
            _overlay = Overlay;
        }

        public void SetUnit(Unit Unit)
        {
            _unit = Unit;
        }

        public Theater GetTheater()
        {
            return _theatre;
        }

        public Template GetTemplate()
        {
            return _template;
        }

        public Terrain GetTerrain()
        {
            return _terrain;
        }

        public Overlay GetOverlay()
        {
            return _overlay;
        }

        public Unit GetUnit()
        {
            return _unit;
        }
    }
}
