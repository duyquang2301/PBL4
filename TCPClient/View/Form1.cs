    using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCPClient
{
    public partial class Form1 : Form
    {

        private HandleClient client;
        public Form1()
        {
            InitializeComponent();
            client = new HandleClient()
            {
                OnConnectionStateChanged = DisconnectedHandler
            };

        }
        private void btnConnect_Click(object sender, EventArgs e)
        {

            if (tbIP.Text.Length == 0 || tbPort.Text.Length == 0)
            {
                MessageBox.Show("Please fill it out completely");
            }
            else
            {
                string IP = tbIP.Text;
                int port = Convert.ToInt32(tbPort.Text);

                
                if(client.IsConnected())
                {
                    client.Disconnect();
                    ConnectionStateChanged(false);
                }
                else
                {

                    try
                    {
                        client.Connect(IP, port);
                        ConnectionStateChanged(true);
                    }
                    catch (SocketException)
                    {
                        MessageBox.Show("Can't connect to server", "notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                    }
                }    
                
            }

        }
        private void DisconnectedHandler()
        {
            Invoke(new MethodInvoker(() =>
            {
                MessageBox.Show("Server has been shut down", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ConnectionStateChanged(false);
            }));
        }

        private void ConnectionStateChanged(bool v)
        {
            tbIP.Enabled = !v;
            tbPort.Enabled = !v;
            btnConnect.Text = v ? "Connecting" : "Connect";
            btnConnect.BackColor = v ? Color.GreenYellow : Color.MistyRose;

        }

        //private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    client.Disconnect();
        //}
    }
}
