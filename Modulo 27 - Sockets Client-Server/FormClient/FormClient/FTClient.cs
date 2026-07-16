using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Drawing;
using System.IO;


namespace FormClient
{
    internal class FTClient
    {
        static IPEndPoint ipEndPoint;
        static Socket socketClient;
        public static string AdressIP = "127.0.0.1";
        public static int PortHost = 1000;
        public static Label labelMessage;

        public static void SendArchive(string archive)
        {
            try
            {
                ipEndPoint = new IPEndPoint(IPAddress.Parse(AdressIP), PortHost);
                socketClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

                string folder = ""; 

                folder += archive.Substring(0, archive.LastIndexOf(@"\") + 1);
                archive = archive.Substring(archive.LastIndexOf(@"\") + 1);

                byte[] sizeFileName = Encoding.UTF8.GetBytes(archive);

                if(sizeFileName.Length > 50000 * 1024)
                {
                    labelMessage.Invoke(new Action(() =>
                    {
                        labelMessage.ForeColor = Color.Red;
                        labelMessage.Text = "O arquivo não pode ser maior do que 50MB.";
                    }));
                    return;
                }

                string pathComplete = folder + archive;
                byte[] fileData = File.ReadAllBytes(pathComplete);
                byte[] clientData = new byte[4 + sizeFileName.Length + fileData.Length];
                byte[] fileName = BitConverter.GetBytes(sizeFileName.Length);

                fileName.CopyTo(clientData, 0);
                sizeFileName.CopyTo(clientData, 4);
                fileData.CopyTo(clientData, 4 + sizeFileName.Length);
                socketClient.Connect(ipEndPoint);
                socketClient.Send(clientData, 0, clientData.Length, 0);
                socketClient.Close();

                labelMessage.Invoke(new Action(() =>
                {
                    labelMessage.ForeColor = Color.Green;
                    labelMessage.Text = $"Arquivo [{archive}] transferido.";
                }));
            }
            catch (Exception ex)
            {
                labelMessage.Invoke(new Action(() =>
                {
                    labelMessage.ForeColor = Color.Red;
                    labelMessage.Text = $"Falha, o servidor não está atendendo.. {ex.Message}";
                }));
            }
            finally
            {
                socketClient.Disconnect(false);
                socketClient.Close();
            }
        }
    }
}
