using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCPServer.Model
{
    public class Client
    {
        [DisplayName("IP Address")]
        public string IP { get; set; }
        [DisplayName("Connected At")]

        public DateTime ConnectedAt { get; set; } = DateTime.Now;
    }
}
