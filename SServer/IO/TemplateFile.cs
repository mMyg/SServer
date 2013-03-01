using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Drawing;

namespace SServer.IO
{
    public class TemplateFile
    {
        private Int16 _width;
        private Int16 _height;
        private Int16 _tilecount;
        private Int16 _zero1;
        private Int32 _size;
        private Int32 _startoffset;
        private Int32 _zero2;
        private Int32 _id;
        private Int32 _tileinfoarrayend;
        private Int32 _tileinfoarraystart;
        private Byte[] _tileinfo;
        private Byte[] _templatebytes;

        public TemplateFile(Byte[] Data)
        {
            _templatebytes = Data;
            MemoryStream stream = new MemoryStream(Data);
            BinaryReader reader = new BinaryReader(stream);
            _width = reader.ReadInt16();
            _height = reader.ReadInt16();
            _tilecount = reader.ReadInt16();
            _zero1 = reader.ReadInt16();
            _size = reader.ReadInt32();
            _startoffset = reader.ReadInt32();
            _zero2 = reader.ReadInt32();
            _id = reader.ReadInt32();
            _tileinfoarrayend = reader.ReadInt32();
            _tileinfoarraystart = reader.ReadInt32();
            stream.Close();
            reader.Close();
            _tileinfo = new Byte[_tilecount];
            for (Int32 i = 0; i < _tilecount; i++)
            {
                _tileinfo[i] = Data[_tileinfoarraystart + i];
            }
        }

        public Byte[] GetTileData(Byte TileIndex)
        {
            Byte[] tilebytes = new Byte[576];
            Int32 tileoffset = _startoffset + (576 * _tileinfo[TileIndex]);
            for (Int32 i = 0; i < 576; i++)
            {
                tilebytes[i] = _templatebytes[i + tileoffset];
            }
            return tilebytes;
        }
    }
}
