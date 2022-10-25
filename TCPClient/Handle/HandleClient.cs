using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCPClient.Request;

namespace TCPClient
{
    public class HandleClient
    {
        private Socket socket;
     
        public Action OnConnectionStateChanged;
        public void Connect(string ipAddress, int port, HandleClient clients)
            {

            if (!IsConnected())
            {
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                try
                {
                    
                    socket.Connect(new IPEndPoint(IPAddress.Parse(ipAddress), port));
                    new Task(async () =>
                    {
                        while (IsConnected())
                        {
                            await Task.Delay(1000);
                        };
                        //Disconnect();
                        OnConnectionStateChanged?.Invoke();
                    }).Start();
                    new Task(() =>
                    {
                        while (true)
                        {
                            byte[] buffer = new byte[1024];
                            try
                            {
                                socket.Receive(buffer);
                            }
                            catch (Exception e)
                            {

                            }
                            string message = Encoding.UTF8.GetString(buffer).Replace("\0", "");
                            switch (message)
                            {
                                case "info":
                                    {
                                        var disks = new DiskHandler().getInfomationHardDisk();
                                        List<DTOrequest> list = new List<DTOrequest>();
                                        foreach (var disk in disks)
                                        {
                                            list.Add(new DTOrequest
                                            {
                                                NameDisk = disk.physicalName,
                                                SerialNumber = disk.serialNumber,
                                                driveType = disk.driveType,
                                                driveFormat = disk.driveFormat,
                                                totalSize = disk.totalSize,
                                                freeSpace = disk.freeSpace,
                                                SectorsPerCluster = disk.sectorsPerClusters,
                                                BytesPerSector = disk.bytesPerSectors
                                            });
                                        }
                                        socket.Send(Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(list)));
                                        break;
                                    }


                            };
                        }
                    }).Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Server not running or fail connect port: " + port);
            }

        }

        public void send(DTOrequest request)
        {
            if (socket != null)
            {
                new Task(() =>
                {
                    try
                    {
                        socket.Send(Encoding.UTF8.GetBytes(request.Serialize()));
                    }
                    catch (SocketException)
                    {
                        OnConnectionStateChanged?.Invoke();
                    }
                }).Start();
            }
        }

        public void Receive()
        {
            new Task(() =>
            {
                byte[] buffer = new byte[1024];
                socket.Receive(buffer);
                string message = Encoding.UTF8.GetString(buffer);
            }).Start();
        }
                

            public bool IsConnected()
            {
                try
                {
                    return (socket != null && !((socket.Poll(1000, SelectMode.SelectRead) && (socket.Available == 0)) || !socket.Connected));
                }
                catch (ObjectDisposedException)
                {
                    return false;
                }
            }
            public void Disconnect()
            {
                if (socket != null)
                {
                    socket.Shutdown(SocketShutdown.Both);
                    socket.Close();
                    socket = null;
                }
            }
    }
}
