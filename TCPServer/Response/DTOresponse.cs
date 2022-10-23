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
        public string diskInf { get; set; }

        public string SerialNumber { get; set; }

        public string totalSize { get; set; }

        public string BytesPerSector { get; set; }
        public string Sector { get; set; }
        public string SectorsPerTrack { get; set; }

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
