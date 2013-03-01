using System;
using System.Collections.Generic;
using System.Text;

namespace SServer.Database
{
    public class Overlays
    {
       /*
       private Int32 unknown1;
        private Int32 unknown2;
        private Int32 unknown3;
        private Int32 unknown4;
        private Int32 unknown5;
        private Int32 unknown6;
        private Int32 unknown7;
        private Int32 unknown8;
        private Int32 unknown9;
        private Int32 unknown10;
        private Int32 unknown11;
        private Int32 unknown12;
        private Int32 _size;
        private Int32 _number;

        public Overlay(Int32 Unknown1, Int32 Unknown2, Int32 Unknown3, Int32 Unknown4, Int32 Unknown5, Int32 Unknown6, Int32 Unknown7, Int32 Unknown8,
            Int32 Unknown9, Int32 Unknown10, Int32 Unknown11, Int32 Unknown12, Int32 Size, Int32 Number)
        {
            unknown1 = Unknown1;
            unknown2 = Unknown2;
            unknown3 = Unknown3;
            unknown4 = Unknown4;
            unknown5 = Unknown5;
            unknown6 = Unknown6;
            unknown7 = Unknown7;
            unknown8 = Unknown8;
            unknown9 = Unknown9;
            unknown10 = Unknown10;
            unknown11 = Unknown11;
            unknown12 = Unknown12;
            _size = Size;
            _number = Number;
        }
        */

        private List<String> _records;

        public Overlays()
        {
            _records = new List<String>();
            _records.Add("CONC");
            _records.Add("SBAG");
            _records.Add("CYCL");
            _records.Add("BRIK");
            _records.Add("BARB");
            _records.Add("WOOD");
            _records.Add("TI1");
            _records.Add("TI2");
            _records.Add("TI3");
            _records.Add("TI4");
            _records.Add("TI5");
            _records.Add("TI6");
            _records.Add("TI7");
            _records.Add("TI8");
            _records.Add("TI9");
            _records.Add("TI10");
            _records.Add("TI11");
            _records.Add("TI12");
            _records.Add("ROAD1");
            _records.Add("ROAD2");
            _records.Add("SQUISH");
            _records.Add("V12");
            _records.Add("V13");
            _records.Add("V14");
            _records.Add("V15");
            _records.Add("V16");
            _records.Add("V17");
            _records.Add("V18");
            _records.Add("FPLS");
            _records.Add("WCRATE");
            _records.Add("SCRATE");
            _records.Add("ACRATE");
            _records.Add("HCRATE");
            _records.Add("SUCRATE");
        }
    }
}
