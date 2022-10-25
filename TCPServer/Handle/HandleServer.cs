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

        private static HandleServer _Instance;

        public List<CBBitems> CBBitems { get;  set; }
        public List<DTOresponse> result { get; set; }
        public static HandleServer Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new HandleServer();
                }
                return _Instance;

            }
            private set { _Instance = value; }

        }

        private Repository Repository;
              

        public Action<List<Client>> OnClientConnectionStateChanged;
        public HandleServer()
        {
            Repository = new Repository();
           
        }
        public List<Client> clients { get; set; }



        public void Stop()
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
            CBBitems = new List<CBBitems>();
            result = new List<DTOresponse>();
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
            foreach (var info in res)
            {
                result.Add(info);
                CBBitems.Add(new CBBitems { Key=info.nameDisk,Text=info.nameDisk});
            }
        
        }

        public  List <DTOresponse> getdata(Socket socket)
        {
            List<DTOresponse> list = new List<DTOresponse>();
            var res = ProcessRequest(socket);
            foreach (var i in res)
            {
                list.Add(i);
            }
            MessageBox.Show(list.ToString());
            return list;
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





        public Socket Send(string IP, string message)
        {
            Socket socket = Repository.ClientSockets.FirstOrDefault(x => x.RemoteEndPoint.ToString() == IP);
            socket.Send(Encoding.UTF8.GetBytes(message));
            return socket;
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
