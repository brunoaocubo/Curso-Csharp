using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormServer
{
    internal class FTServer
    {
        static IPEndPoint ipEndpoint;
        static Socket socketServer;
        public static string AddressIP = "127.0.0.1";
        public static int PortHost = 1000;
        public static string pathFolderArchives = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\";
        public static ListBox listMessage;

        public static void StartServer()
        {
            try
            {
                ipEndpoint = new IPEndPoint(IPAddress.Parse(AddressIP), PortHost);
                socketServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socketServer.Bind(ipEndpoint);
            }
            catch (Exception ex)
            {
                listMessage.Invoke(new Action(() =>
                {
                    listMessage.Items.Add("Erro ao iniciar o servidor: " + ex.Message);
                    listMessage.SetSelected(listMessage.Items.Count - 1, true);
                }));

                return;
            }

            try
            {
                socketServer.Listen(100);
                listMessage.Invoke(new Action(() =>
                {
                    listMessage.Items.Add("Servidor em atendimento, aguardando arquivo...");
                    listMessage.SetSelected(listMessage.Items.Count - 1, true);
                }));

                Socket socketClient = socketServer.Accept();
                socketClient.ReceiveBufferSize = 16384;

                byte[] dataClient = new byte[1024 * 50000];
                int sizeBytesReceive = socketClient.Receive(dataClient, dataClient.Length, 0);
                int sizeNameArchive = BitConverter.ToInt32(dataClient, 0);
                string nameArchive = Encoding.UTF8.GetString(dataClient, 4, sizeNameArchive);

                BinaryWriter writer = new BinaryWriter(File.Open(pathFolderArchives + nameArchive, FileMode.Append));
                writer.Write(dataClient, 4 + sizeNameArchive, sizeBytesReceive - 4 - sizeNameArchive);

                while(sizeBytesReceive > 0)
                {
                    sizeBytesReceive = socketClient.Receive(dataClient, dataClient.Length, 0);

                    if(sizeBytesReceive == 0)
                    {
                        writer.Close();
                    }
                    else
                    {
                        writer.Write(dataClient, 0, sizeBytesReceive);
                    }

                    listMessage.Invoke(new Action(() =>
                    {
                        listMessage.Items.Add($"Arquivo recebido e arquivado: [{sizeNameArchive}]" );
                        listMessage.SetSelected(listMessage.Items.Count - 1, true);
                    }));

                    writer.Close();
                    socketClient.Close();
                }
            }
            catch (SocketException ex)
            {
                listMessage.Invoke(new Action(() =>
                {
                    listMessage.Items.Add($"Erro ao receber arquivo: {ex.Message}");
                    listMessage.SetSelected(listMessage.Items.Count - 1, true);
                }));
            }
            finally
            {
                socketServer.Close();
                socketServer.Dispose();
                StartServer();
            }
        }
    }
}