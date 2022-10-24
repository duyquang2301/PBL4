using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCPClient.Request;
using TCPServer.Model;
using TCPServer.Response;

namespace TCPServer
{
    public class HandleServer
    {
        private Socket Socket;


        private Repository Repository;

        public Action<List<Client>> OnClientConnectionStateChanged;
        public HandleServer()
        {
            Repository = new Repository();
        }
        public List<Client> clients { get; set; }



        internal void Stop()
        {
            foreach (Socket clientSocket in Repository.ClientSockets)
            {
                clientSocket.Shutdown(SocketShutdown.Both);
            }

            if (Socket != null)
            {
                Socket.Close();
            }

            Repository.Clear();
            OnClientConnectionStateChanged?.Invoke(Repository.Clients);
        }
        public void Connect(string ipAddress, int port)
        {
            if (!IsListening())
            {   
                Socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                Socket.Bind(new IPEndPoint(IPAddress.Parse(ipAddress), port));
                Socket.Listen(100);
                new Task(() =>
                {
                    while (true)
                    {
                        try
                        {
                            Socket clientSocket = Socket.Accept();
                            Repository.AddClient(clientSocket);
                            OnClientConnectionStateChanged?.Invoke(Repository.Clients);
                            new Task(() => Receive(clientSocket)).Start();
                        }
                        catch (SocketException)
                        {
                            break;
                        }
                    }
                }).Start();
            }
        }

        public void Receive(Socket socket)
        {
            var res = ProcessRequest(socket);
            if (res != null)
            {
                foreach (var info in res)
                {
                    MessageBox.Show(info.nameDisk);
                }

            }
            else
            {
                MessageBox.Show("Not read");
            }
        }

        public List<DTOresponse> ProcessRequest(Socket clientSocket)
        {
            byte[] buffer = new byte[1024];
            int size = clientSocket.Receive(buffer);
            if (size <= 0)
            {
                return null;
            }
            var request = JsonConvert.DeserializeObject<List<DTOresponse>>(Encoding.UTF8.GetString(buffer));
            return request;
        }



        public void Send(string IP, string message)
        {
            Socket socket = Repository.ClientSockets.FirstOrDefault(x => x.RemoteEndPoint.ToString() == IP);
            socket.Send(Encoding.UTF8.GetBytes(message));
        }
        public bool IsListening()
        {
            try
            {
                return Socket != null && Socket.IsBound && !(Socket.Poll(1, SelectMode.SelectRead) && Socket.Available == 0);
            }
            catch (Exception)
            {
                return false;
            }
        }


    }
}
