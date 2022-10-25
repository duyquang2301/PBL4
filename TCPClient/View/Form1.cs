    using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            client = new HandleClient();

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

                client.Connect(IP, port, client);
                btnConnect.BackColor = Color.Green;
                btnConnect.Text = "Connecting";
            }

        }

        //private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    client.Disconnect();
        //}
    }
}
