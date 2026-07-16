using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormServer
{
    public partial class Form1 : Form
    {
        Task task;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            linkSelectFolder.Text = FTServer.pathFolderArchives;
            FTServer.listMessage = listLogs;
        }

        private void btnConnectServer_Click(object sender, EventArgs e)
        {
            int port = (int)inputPortServer.Value;
            string endIP = inputIP.Text;

            try
            {
                FTServer.AddressIP = endIP;
                FTServer.PortHost = port;

                task = Task.Factory.StartNew(() =>
                {
                    FTServer.StartServer();
                });
            }
            catch (Exception ex)
            {
                listLogs.Invoke(new Action(() =>
                {
                    listLogs.Items.Add("Erro ao conectar: " + ex.Message);
                    listLogs.SetSelected(listLogs.Items.Count - 1, true);
                }));
            }
        }

        private void btnDisconnectServer_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Restart();
            }
            catch (Exception ex)
            {
                listLogs.Invoke(new Action(() =>
                {
                    listLogs.Items.Add("Erro: " + ex.Message);
                    listLogs.SetSelected(listLogs.Items.Count - 1, true);
                }));

            }
        }

        private void linkSelectFolder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            
            if(dialog.ShowDialog() != DialogResult.Cancel)
            {
                FTServer.pathFolderArchives = dialog.SelectedPath + @"\";
                linkSelectFolder.Text = FTServer.pathFolderArchives;
            }
        }
    }
}
