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

namespace File_Info
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string folder = @"C:\Users\bruno.carvalho\Desktop\";
            string file = "Teste.txt";
            string path_file = folder + file;

            FileInfo info = new FileInfo(path_file);

            if (!info.Exists)
            {
                File.Create(folder + file).Close();   
            }

            list.Items.Clear();
            list.Items.Add(info.FullName);
            list.Items.Add(info.Name);
            list.Items.Add(info.Directory.FullName);
            list.Items.Add(info.DirectoryName);
            list.Items.Add(info.CreationTime);
            list.Items.Add(info.Extension);
            list.Items.Add(info.LastAccessTime);
        }
    }
}
