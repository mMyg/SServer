using System;
using System.Collections.Generic;
using System.Text;

namespace SServer.IO
{
    public class Bytes
    {
        protected LinkedList<Byte> _data;

        public Bytes()
        {
            _data = new LinkedList<Byte>();
        }
        public Bytes(Byte[] Data)
        {
            _data = new LinkedList<Byte>(Data);
        }
        
        private void addend(Byte B)
        {
            _data.AddLast(B);
        }
        private void addstart(Byte B)
        {
            _data.AddFirst(B);
        }
        private Byte removeend()
        {
            Byte removebyte = _data.Last.Value;
            _data.RemoveLast();
            return removebyte;
        }
        private Byte removestart()
        {
            Byte removebyte = _data.First.Value;
            _data.RemoveFirst();
            return removebyte;
        }

        // Right hand side
        // Preserves order
        protected Byte StartRemoveByte()
        {
            return removestart();
        }
        protected Int16 StartRemoveInt16()
        {
            return BitConverter.ToInt16(StartRemoveBytes(2), 0);
        }
        protected UInt16 StartRemoveUInt16()
        {
            return BitConverter.ToUInt16(StartRemoveBytes(2), 0);
        }
        protected Int32 StartRemoveInt32()
        {
            return BitConverter.ToInt32(StartRemoveBytes(4), 0);
        }
        protected UInt32 StartRemoveUInt32()
        {
            return BitConverter.ToUInt32(StartRemoveBytes(4), 0);
        }
        protected Int64 StartRemoveInt64()
        {
            return BitConverter.ToInt64(StartRemoveBytes(8), 0);
        }
        protected UInt64 StartRemoveUInt64()
        {
            return BitConverter.ToUInt64(StartRemoveBytes(8), 0);
        }
        protected Byte[] StartRemoveBytes(int length)
        {
            Byte[] tempBytes = new Byte[length];
            for (int i = 0; i < tempBytes.Length; i++)
            {
                tempBytes[i] = removestart();
            }
            return tempBytes;
        }
        protected Char[] StartRemoveChars(int length)
        {
            return StartRemoveString(length).ToCharArray();
        }
        protected String StartRemoveString(int length)
        {
            return System.Text.ASCIIEncoding.ASCII.GetString(StartRemoveBytes(length));
        }

        protected void EndAddByte(Byte B)
        {
            addend(B);
        }
        protected void EndAddInt16(Int16 I)
        {
            EndAddBytes(BitConverter.GetBytes(I));
        }
        protected void EndAddUInt16(UInt16 I)
        {
            EndAddBytes(BitConverter.GetBytes(I));
        }
        protected void EndAddInt32(Int32 I)
        {
            EndAddBytes(BitConverter.GetBytes(I));
        }
        protected void EndAddUInt32(UInt32 I)
        {
            EndAddBytes(BitConverter.GetBytes(I));
        }
        protected void EndAddInt64(Int64 I)
        {
            EndAddBytes(BitConverter.GetBytes(I));
        }
        protected void EndAddUInt64(UInt64 I)
        {
            EndAddBytes(BitConverter.GetBytes(I));
        }
        protected void EndAddBytes(Byte[] B)
        {
            for (int i = 0; i < B.Length; i++)
            {
                addend(B[i]);
            }
        }
        protected void EndAddChars(Char[] C)
        {
            for (int i = 0; i < C.Length; i++)
            {
                addend((Byte)C[i]);
            }
        }       
        protected void EndAddString(String S)
        {
            EndAddBytes(System.Text.ASCIIEncoding.ASCII.GetBytes(S));
        }

        // Left hand side
        // Reverses order
        protected void StartAddByte(Byte B)
        {
            addstart(B);
        }
        protected void StartAddInt16(Int16 I)
        {
            StartAddBytes(BitConverter.GetBytes(I));
        }
        protected void StartAddUInt16(UInt16 I)
        {
            StartAddBytes(BitConverter.GetBytes(I));
        }
        protected void StartAddInt32(Int32 I)
        {
            StartAddBytes(BitConverter.GetBytes(I));
        }
        protected void StartAddUInt32(UInt32 I)
        {
            StartAddBytes(BitConverter.GetBytes(I));
        }
        protected void StartAddInt64(Int64 I)
        {
            StartAddBytes(BitConverter.GetBytes(I));
        }
        protected void StartAddUInt64(UInt64 I)
        {
            StartAddBytes(BitConverter.GetBytes(I));
        }
        protected void StartAddBytes(Byte[] B)
        {
            for (int i = 0; i < B.Length; i++)
            {
                addstart(B[i]);
            }
        }
        protected void StartAddBytes(Char[] C)
        {
            for (int i = 0; i < C.Length; i++)
            {
                addstart((Byte)C[i]);
            }
        }      
        protected void StartAddString(String S)
        {
            StartAddBytes(System.Text.ASCIIEncoding.ASCII.GetBytes(S));
        }

        protected Byte EndRemoveByte()
        {
            return removeend();
        }
        protected Int16 EndRemoveInt16()
        {
            return BitConverter.ToInt16(EndRemoveBytes(2), 0);
        }
        protected UInt16 EndRemoveUInt16()
        {
            return BitConverter.ToUInt16(EndRemoveBytes(2), 0);
        }
        protected Int32 EndRemoveInt32()
        {
            return BitConverter.ToInt32(EndRemoveBytes(4), 0);
        }
        protected UInt32 EndRemoveUInt32()
        {
            return BitConverter.ToUInt32(EndRemoveBytes(4), 0);
        }
        protected Int64 EndRemoveInt64()
        {
            return BitConverter.ToInt64(EndRemoveBytes(8), 0);
        }
        protected UInt64 EndRemoveUInt64()
        {
            return BitConverter.ToUInt64(EndRemoveBytes(8),0);
        }
        protected Byte[] EndRemoveBytes(int length)
        {
            Byte[] tempBytes = new Byte[length];
            for (int i = 0; i < tempBytes.Length; i++)
            {
                tempBytes[i] = removeend();
            }
            return tempBytes;
        }
        protected Char[] EndRemoveChars(int length)
        {
            return EndRemoveString(length).ToCharArray();
        }
        protected String EndRemoveString(int length)
        {
            return System.Text.ASCIIEncoding.ASCII.GetString(EndRemoveBytes(length));
        }
    }
}
