using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            string folder = @"C:\Users\bruno.carvalho\Desktop\";
            string archive = "teste.txt";

            /* CREATE/ DELETE/ EXISTS
            //bool result = File.Exists(folder + archive);
            //label1.Text = result.ToString();
            if(!File.Exists(folder + archive))
            {
                label1.Text = $"Arquivo Criado em: {folder + archive}";
                File.Create(folder + archive).Close();
            }
            else
            {
                label1.Text = $"Deletando o arquivo em: {folder + archive}";
                File.Delete(folder + archive);
            }*/

            /*COPY*/
            if(File.Exists(folder + archive))
            {
                string path = folder + archive;
                string copyFile = folder + "Copia.txt";

                File.Copy(path, folder + "Copia.txt");
                label1.Text = $"Arquivo copiado para a pasta: {folder}";
            }
        }
    }
}
