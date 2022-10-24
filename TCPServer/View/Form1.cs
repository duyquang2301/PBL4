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
            if (!server.IsListening())
            {
                string ipAddress = tbIP.Text;
                int port = Convert.ToInt32(tbPort.Text);
                server.Connect(ipAddress, port);
                tbStatus.Text = "Server running";
                tbStatus.BackColor = Color.Green;
            }
            else
            {
                MessageBox.Show("Server are running");
            }
            

        }


        private void btnStop_Click(object sender, EventArgs e)
        {
            if (server.IsListening())
            {
                server.Stop();
                tbStatus.Text = "Server turn off";
                tbStatus.BackColor = Color.Red;
            }
            else
            {   
                MessageBox.Show("Server not start","Warning");
            }    
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
