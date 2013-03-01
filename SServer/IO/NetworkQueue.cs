using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using SServer.Enums;
using SServer.Objects;
using SServer.Structs;

namespace SServer.IO
{
    public class NetworkQueue
    {
        private List<Byte[]> _queuedata;
        private Int32 _queuesize;

        public NetworkQueue(Int32 Size)
        {
            _queuesize = Size;
            _queuedata = new List<Byte[]>(Size);
        }

        public Boolean Enqueue(Byte[] B)
        {
            if (_queuedata.Count < _queuesize)
            {
                lock (_queuedata)
                {
                    _queuedata.Add(B);
                    _queuesize++;
                }
                return true;
            }
            return false;
        }

        public Byte[] Dequeue()
        {
            Byte[] ReturnQueueItem = _queuedata[0];
            lock (_queuedata)
            {               
                _queuedata.RemoveAt(0);
                --_queuesize;
            }
            return ReturnQueueItem;
        }
       
        public Int32 CurrentItems()
        {
            Int32 returnint = -1;
            lock (_queuedata)
            {
                returnint = _queuedata.Count;
            }
            return returnint;
        }

        public Boolean HasItems()
        {
            Boolean hasitems = false;
            lock (_queuedata)
            {
                if (_queuedata.Count > 0)
                {
                    hasitems = true;
                }
            }
            return hasitems;
        }
    }
}
