using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FTClient.labelMessage = txtStatus;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void linkFile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "Enviar Arquivo";

            if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                linkFile.Text = fileDialog.FileName;
            }
        }

        private void btnSendFile_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(inputIP.Text) || string.IsNullOrEmpty(inputPort.Value.ToString()))
            {
                txtStatus.ForeColor = Color.Red;
                txtStatus.Text = "Dados inválidos";
                return;
            }

            string addressIP = inputIP.Text;
            int port = (int)inputPort.Value;
            string nameArchive = linkFile.Text;

            FTClient.AdressIP = addressIP;
            FTClient.PortHost = port;

            try
            {
                Task.Factory.StartNew(() =>
                {
                    FTClient.SendArchive(nameArchive);
                });
            }
            catch (Exception ex)
            {
                txtStatus.ForeColor = Color.Red;
                txtStatus.Text = $"Erro: [{ex.Message}].";
            }
        }
    }
}
