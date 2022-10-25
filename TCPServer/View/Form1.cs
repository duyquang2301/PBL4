using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCPServer.Model;
using TCPServer.Response;

namespace TCPServer
{
    public partial class Form1 : Form
    {
        HandleServer server;
        Repository Repository = new Repository();
        List<DTOresponse> list = new List<DTOresponse>();
    
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
            resetCBB();
            string IP = dgvClient.SelectedRows[0].Cells["IP"].Value.ToString();
            server.Send(IP, "info");
            cbbSelectedVolume.Items.AddRange(server.CBBitems.ToArray());
            
        }
        private void resetCBB()
        {
            cbbSelectedVolume.Items.Clear();
            txtText.Text = "";
            txtFormat.Text = "";
            txtType.Text = "";
            txtfreespace.Text = "";
            txtCapacity.Text = "";
            lbl_BytesPerSector.Text = "Bytes per Sector";
            lbserinumber.Text = "Serial Number";
            lbl_TracksPerCylinder.Text = "Sector Cluster";
        }
        private void cbbSelectedVolume_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            if(cbbSelectedVolume.SelectedIndex != -1)
            {
                txtText.Text = server.result[cbbSelectedVolume.SelectedIndex].nameDisk.ToString();
                txtFormat.Text = server.result[cbbSelectedVolume.SelectedIndex].driveFormat.ToString();
                txtType.Text = server.result[cbbSelectedVolume.SelectedIndex].driveType.ToString();
                txtfreespace.Text = DTOresponse.FormatBytes(server.result[cbbSelectedVolume.SelectedIndex].freeSpace).ToString();
                txtCapacity.Text = DTOresponse.FormatBytes(server.result[cbbSelectedVolume.SelectedIndex].totalSize).ToString();
                lbl_BytesPerSector.Text = "Bytes per Sector: " + server.result[cbbSelectedVolume.SelectedIndex].BytesPerSector;
                lbserinumber.Text="Serial Number: " + server.result[cbbSelectedVolume.SelectedIndex].SerialNumber;
                lbl_TracksPerCylinder.Text = "Sector Cluster: " + server.result[cbbSelectedVolume.SelectedIndex].SectorsPerCluster;
            }else
            {
                txtText.Text = "";
                txtFormat.Text = "";
                txtType.Text = "";
                txtfreespace.Text = "";
                txtCapacity.Text = "";
                lbl_BytesPerSector.Text = "Bytes per Sector";
                lbserinumber.Text = "Serial Number";
                lbl_TracksPerCylinder.Text = "Sector Cluster";
            }
        }
    }

}
