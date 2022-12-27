using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCPServer.Response
{
    public class DTOresponse
    {
        public string nameDisk { get; set; }

        public string SerialNumber { get; set; }

        public string driveFormat { get; set; }
        public string driveType { get; set; }
        public double totalSize { get; set; }
        public double freeSpace { get; set; }
        public ulong BytesPerSector { get; set; }
        public ulong SectorsPerCluster { get; set; }

        public static string FormatBytes(double bytes)
        {
            string[] Suffix = { "B", "KB", "MB", "GB", "TB" };
            int i;
            double dblSByte = bytes;
            for (i = 0; i < Suffix.Length && bytes >= 1024; i++, bytes /= 1024)
            {
                dblSByte = bytes / 1024.0;
            }

            return String.Format("{0:0.##} {1}", dblSByte, Suffix[i]);
        }
        public static DTOresponse Deserialize(string obj)
        {
            return JsonConvert.DeserializeObject<DTOresponse>(obj);
        }

        public string Serialize()
        {
            return JsonConvert.SerializeObject(this);
        }

    }
}
