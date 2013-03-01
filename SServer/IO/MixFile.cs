using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace SServer.IO
{
    public class MixFile
    {
        struct MixRecord
        {
            public UInt32 _id;
            public Int32 _offset;
            public Int32 _size;

            public MixRecord(UInt32 Id, Int32 Offset, Int32 Size)
            {
                _id = Id;
                _offset = Offset;
                _size = Size;
            }
        }

        private String _mixfilename;
        private Byte[] _mixbytes;
        private Int16 _numberofrecords;
        private Int32 _lengthofrecords;
        private MixRecord[] _mixrecords;
      
        public MixFile(String MixFile)
        {
            try
            {
                _mixfilename = MixFile;
                FileStream stream = new FileStream(MixFile, FileMode.Open);
                BinaryReader reader = new BinaryReader(stream);
                _mixbytes = reader.ReadBytes((Int32)stream.Length);
                stream.Close();
                stream = new FileStream(MixFile, FileMode.Open);
                reader = new BinaryReader(stream);
                _numberofrecords = reader.ReadInt16();
                _lengthofrecords = reader.ReadInt32();
                _mixrecords = new MixRecord[_numberofrecords];
                for (Int32 i = 0; i < _mixrecords.Length; i++)
                {
                    _mixrecords[i] = new MixRecord(reader.ReadUInt32(), (reader.ReadInt32() + (_numberofrecords * 12) + 6), reader.ReadInt32());
                }
                stream.Close();
            }
            catch (Exception e)
            {Console.WriteLine(e);}
        }

        public Byte[] GetFileByString(String FileName)
        {
            UInt32 localfileid = Util_GetMixFileId(FileName);
            Byte[] localfilebytes = new Byte[0];
            for (Int16 i = 0; i < _numberofrecords; i++)
            {
                if (_mixrecords[i]._id == localfileid)
                {
                    localfilebytes = new Byte[_mixrecords[i]._size];
                    for (Int32 j = 0; j < localfilebytes.Length; j++)
                    {
                        localfilebytes[j] = _mixbytes[j + _mixrecords[i]._offset];
                    }
                    break;
                }
            }
            return localfilebytes;
        }

        public Int32 GetFileCount()
        {
            return _mixrecords.Length;
        }

        public UInt32 Util_GetMixFileId(String FileName)
        {
            Int32 i = 0;
            UInt32 id = 0;
            Int32 l = FileName.Length;
            while (i < l)
            {
                UInt32 a = 0;
                for (int j = 0; j < 4; j++)
                {
                    a >>= 8;
                    if (i < l)
                    {
                        a |= (UInt32)(FileName[i++]) << 24;
                    }
                }
                id = (id << 1 | id >> 31) + a;
            }
            return id;
        }
    }
}
