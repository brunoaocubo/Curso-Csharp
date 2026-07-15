using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SocketClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
           
            try
            {
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1234);
                socket.Connect(endPoint);

                Console.WriteLine("Conectado ao servidor!");
                Console.WriteLine("Insira uma informação para enviar...");

                string info = Console.ReadLine();

                byte[] infoSend = Encoding.Default.GetBytes(info);
                socket.Send(infoSend, 0, info.Length, SocketFlags.None);

            }
            catch (Exception)
            {
                Console.WriteLine("Não foi possível conectar ao servidor...");
            }

            socket.Close();
        }
    }
}
