using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace ReadWrite_Files
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWriteText_Click(object sender, EventArgs e)
        {
            string path = @"c:\teste\file.txt";
            StreamWriter writer = new StreamWriter(path, true, Encoding.Default);

            //string line = txtContent.Text;
            //writer.WriteLine(line);

            string txt = txtContent.Text;
            writer.Write(txt);

            writer.Flush();
            writer.Dispose();
            writer.Close();
        }

        private void btnReadText_Click(object sender, EventArgs e)
        {
            string path = @"c:\teste\file.txt";
            StreamReader reader = new StreamReader(path, Encoding.Default);
            
            string linha = reader.ReadLine();

            /*
            string txt = reader.ReadToEnd();
            //string linha = reader.ReadLine();

            txtContent.Text = "123";
            Debug.WriteLine(linha);

            while(linha != null)
            {
                txtContent.Text += linha + "\n";
                linha = reader.ReadLine();
            }
            */

            while (!reader.EndOfStream)
            {
                txtContent.Text += (char)reader.Read();
            }

            reader.Close();
        }
    }
}
