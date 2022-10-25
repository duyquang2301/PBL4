using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TCPServer.Model
{
    public class Repository
    {
        public List<Client> Clients { get; set; }
        public List<Socket> ClientSockets { get; set; }

        public static Repository instance;


        public Repository()
        {
            Clients = new List<Client>();
            ClientSockets = new List<Socket>();
           // Responses = new List<ResponseLog>();
        }

        public static Repository GetInstance()
        {
            if (instance == null)
            {
                instance = new Repository();
            }
            return instance;
        }
        public void AddClient(Socket socket)
        {
            Clients.Add(new Client
            {
                IP = socket.RemoteEndPoint.ToString(),
                ConnectedAt = DateTime.Now
            });
            ClientSockets.Add(socket);
        }
        public void RemoveClient(Socket socket)
        {
            ClientSockets.Remove(socket);
            Clients = Clients.Where(x => x.IP != socket.RemoteEndPoint.ToString()).ToList();
        }
        public void Clear()
        {
            Clients.Clear();
            ClientSockets.Clear();
          //  Responses.Clear();
        }
        public Socket getSocket(string IP)
        {
            Socket socket;
               socket = ClientSockets.Find(x => x.RemoteEndPoint.ToString() == IP);
            return socket;
        }
    }
}
