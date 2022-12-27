using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TCPClient.Request
{
    public class DTOrequest
    {
        public string NameDisk { get; set; }
        public string SerialNumber { get; set; }
        public string driveFormat { get; set; }
        public string driveType { get; set; }
        public double totalSize { get; set; }
        public double freeSpace { get; set; }
        public ulong BytesPerSector { get; set; }
        public ulong SectorsPerCluster { get; set; }
     


        public static DTOrequest Deserialize(string obj)
        {
            return JsonConvert.DeserializeObject<DTOrequest>(obj);
        }

        public string Serialize()
        {
            return JsonConvert.SerializeObject(this);
        }
    }

    
}
