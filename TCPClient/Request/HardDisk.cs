using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TCPClient.Model
{
    public class HardDisk
    {
        public string physicalName { get; set; }
        public string serialNumber { get; set; }
        public string driveFormat { get; set; }
        public string driveType { get; set; }
        public double totalSize { get; set; }
        public double freeSpace { get; set; }
        public ulong sectorsPerClusters { get; set; }
        public ulong bytesPerSectors { get; set; }

    }
}
