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

        //HardDisk hardDisk { get; set; }
        //public void getInfoHardDisk()
        //{
        //    ManagementObjectSearcher diskInfors = new ManagementObjectSearcher("Select * from Win32_Diskdrive");
        //    foreach (ManagementObject diskInfo in diskInfors.Get())
        //    {
        //        hardDisk = new HardDisk();

        //        hardDisk.physicalName = diskInfo["MediaType"].ToString();
        //        hardDisk.serialNumber = diskInfo["serial"].ToString();
        //        hardDisk.totalSize = diskInfo["size"].ToString();
        //        hardDisk.freeSize = diskInfo["size"].ToString();
        //    }
        //}
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
            DTOresponse res = ProcessRequest(socket);
            if(res != null)
            {
                string m = res.Serialize();
                MessageBox.Show(m);

            }
            else
            {
                MessageBox.Show("aa");
            }    
        }

        public DTOresponse ProcessRequest(Socket clientSocket)
        {
            byte[] buffer = new byte[1024];
            int size = clientSocket.Receive(buffer);
            if (size <= 0)
            {
                return null;
            }
            DTOrequest request = DTOrequest.Deserialize(Encoding.UTF8.GetString(buffer).Replace("\0", ""));
            
            return new DTOresponse
            {
                diskInf = request.NameDisk,
                SerialNumber = request.SerialNumber,
                driveFormat = request.driveFormat,
                driveType = request.driveType,
                totalSize = request.totalSize,
                freeSpace = request.freeSpace,
                BytesPerSector = request.BytesPerSector,
                SectorsPerCluster = request.SectorsPerCluster
            };

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
