using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCPServer.Model;
using TCPServer.Response;

namespace TCPServer.View
{
    public partial class detail : Form
    {
        public detail(List<DTOresponse> result)
        {
            InitializeComponent();
            List<CBBitems> data = new List<CBBitems>();
            foreach (DTOresponse i in result)
            {
                data.Add(new CBBitems { Text = i.nameDisk, Key = i.nameDisk });
            }
            
            List<DTOresponse> dTOresponses = new List<DTOresponse>();
            foreach (DTOresponse i in result)
            {
                dTOresponses.Add(i);
            }
            txtCapacity.Text = (dTOresponses.Find(x=>x.nameDisk.ToString() == "C:\\")).ToString();
        }

        
    }
}
