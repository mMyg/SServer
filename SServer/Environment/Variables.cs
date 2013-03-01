using System;
using System.Collections.Generic;
using System.Text;

namespace SServer.Environment
{
    public static class Variables
    {
        public static readonly Byte UNIQUEID_START_OFFSET = 10;
        public static readonly Byte CHANNEL_NAME_LENGTH = 80;
        public static readonly Int32 QUEUE_LENGTH = 128;
        public static readonly Int32 MAP_PIXEL_DIMENSION = 3072;
        public static readonly Int32 ENGINE_TICK_RATE = 1000;
        public static readonly Int32 BUFFER_SIZE = 1024;
        public static readonly Int32 MAP_UNIT_SLOTS = 110;
        public static readonly Int32 MAP_CELL_DIMENSION = 128;
        public static readonly Int32 SERVER_PORT = 2525;
        public static readonly Int32 SQUARE_CELL_WIDTH = 24;
        public static readonly Int32 CLIENT_DEFAULT_TIMEOUT = 60000;
        public static readonly Int64 SOLE_SURVIVOR_MAJOR_VERSION = 1;
        public static readonly Int32 SOLE_SURVIVOR_MINOR_VERSION = 261;
        public static readonly String TEMPERATE_TEMPLATE_ID = ".TEM";
        public static readonly String DESERT_TEMPLATE_ID = ".DES";
        public static readonly String WINTER_TEMPLATE_ID = ".WIN";
        public static readonly String INI_FILE_EXTENSION = ".INI";
        public static readonly String BIN_FILE_EXTENSION = ".BIN";
        public static readonly String OUTPUT_FILE_EXTENSION = ".XML";
        public static readonly Boolean SERVER_REUSE_SOCKETS = true;
    }
}
