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

namespace Directory_Info
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Execute_Click(object sender, EventArgs e)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(@"C:\Users\bruno.carvalho\Desktop");

            list.Items.Clear();
            list.Items.Add(dirInfo.FullName);
            list.Items.Add(dirInfo.Parent);
            list.Items.Add(dirInfo.Name);
            list.Items.Add(dirInfo.CreationTime);
            list.Items.Add(dirInfo.Exists);
            list.Items.Add(dirInfo.Root);
            list.Items.Add("------------------");

            DirectoryInfo[] dirs = dirInfo.GetDirectories();
            foreach (var item in dirs)
            {
                list.Items.Add(item.FullName);
            }
            list.Items.Add("------------------");

            FileInfo[] files = dirInfo.GetFiles();
            foreach (var item in files)
            {
                list.Items.Add(item.Name);
            }
        }
    }
}
