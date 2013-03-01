using System;
using System.Collections.Generic;
using System.Text;

namespace SServer.Enums
{
    [Flags]
    public enum ServerPriority
    {
        Immediate = 1,
        High = 10,
        Medium = 100,
        Low = 1000
    };
}
