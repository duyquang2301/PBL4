using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCPServer.Model;

namespace TCPServer
{
    public partial class Form1 : Form
    {
        HandleServer server;
        public Form1()
        {   
            
            InitializeComponent();
            dgvClient.DataSource = new List<Client>();
            server = new HandleServer()
            {
                OnClientConnectionStateChanged = UpdateClient
            };    
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            tbStatus.Text += "server start" + Environment.NewLine;
            //IPAddress ip = IPAddress.Parse(tbIP.Text);
            //server.Start(ip, Convert.ToInt32(tbPort.Text));
            string ipAddress = tbIP.Text;
            int port = Convert.ToInt32(tbPort.Text);
            server.Connect(ipAddress, port);

        }


        private void btnStop_Click(object sender, EventArgs e)
        {
            //if(server.IsStarted)
            //{
            //    server.Stop();
            //}
        }
        public void UpdateClient(List<Client> clients)
        {
            Invoke(new MethodInvoker(delegate
            {
                dgvClient.DataSource = null;
                dgvClient.DataSource = clients;
            }));
        }

        private void dgvClient_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvClient.SelectedRows.Count == 1)
            {
                btnRead.Enabled = true;
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            string IP = dgvClient.SelectedRows[0].Cells["IP"].Value.ToString();
            server.Send(IP, "info");
        }
    }
}
