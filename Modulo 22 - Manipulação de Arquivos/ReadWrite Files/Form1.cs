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
        byte[] buffer;
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

        private void btnReadBinary_Click(object sender, EventArgs e)
        {
            string path = @"c:\teste\file.txt";
            string path2 = @"c:\teste\imagem.png";
            string path3 = @"c:\teste\video.mp4";
            FileStream file = File.OpenRead(path3);
            BinaryReader reader = new BinaryReader(file, Encoding.Default);

            /*
            while (reader.BaseStream.Position != reader.BaseStream.Length)
            {
                byte b = reader.ReadByte();
                txtContent.Text += (char)b + " ";
            }*/

            buffer = reader.ReadBytes((int)reader.BaseStream.Length);

            /*
            foreach (byte b in buffer)
            {
                txtContent.Text += (char)b;
            }
            */

            reader.Close();

            //buffer = File.ReadAllBytes(path);
        }

        private void btnWriteBinary_Click(object sender, EventArgs e)
        {
            string path = @"c:\teste\file.txt";
            string path2 = @"c:\teste\imagemNovo.png";
            string path3 = @"c:\teste\videoNovo.mp4";
            FileStream file = File.OpenWrite(path3);
            BinaryWriter writer = new BinaryWriter(file);

            writer.Write(buffer);

            writer.Flush();
            writer.Dispose();
            writer.Close();
        }
    }
}
