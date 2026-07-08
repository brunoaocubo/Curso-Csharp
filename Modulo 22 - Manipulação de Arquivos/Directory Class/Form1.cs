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

namespace Directory_Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Execute_Click(object sender, EventArgs e)
        {
            string userPC = Environment.UserName;
            string path_teste = $@"C:\Users\{userPC}\Desktop\Teste Directory\";
            string path_desktop = $@"C:\Users\{userPC}\Desktop";

            list.Items.Clear();

            #region Directory.Exists();
            /*
            bool res = Directory.Exists(path_teste);
            list.Items.Add(res);
            */
            #endregion

            #region Directory.CreateDirectory();
            /*
            if (!res)
            {
                Directory.CreateDirectory(path_teste);
            }
            */
            #endregion

            #region Directory.Delete();
            /*
            if (res)
            {
                Directory.Delete(path_teste);
            }
            */
            #endregion

            #region Directory.Move();
            /*
            if (res)
            {
               string target_path = $@"C:\Users\{userPC}\Desktop\Teste Target Directory\Outro Nome Directory\";

               Directory.Move(path_teste, target_path);
            }
            */
            #endregion

            #region Directory.GetDirectories();
            /*
            string[] directories = Directory.GetDirectories($@"C\Users\{userPC}\Desktop\");

            for (int i = 0; i < directories.Length; i++)
            {
                list.Items.Add(directories[i]);
            }
            */
            #endregion

            #region Directory.GetFiles();
            /*
            string[] files = Directory.GetFiles($@"C:\Users\{userPC}\Desktop\");

            for (int i = 0; i < files.Length; i++)
            {
                list.Items.Add(files[i]);
            }
            */
            #endregion

            #region Directory.GetDirectoryRoot();
            //list.Items.Add(Directory.GetDirectoryRoot(path_teste));
            #endregion

            #region Directory.GetLogicalDrives();
            /*
            string[] logicalDrives = Directory.GetLogicalDrives();
            for (int i = 0; i < logicalDrives.Length; i++)
            {
                list.Items.Add(logicalDrives[i]);
            }*/
            #endregion

            #region Directory.GetParent();
            /*
            DirectoryInfo parentInfo = Directory.GetParent(path_desktop);

            if (parentInfo.Exists)
            {
                list.Items.Add(parentInfo.FullName);
            }
            */
            #endregion

            #region Directory.GetCurrentDirectory();
            //string currentDirectory = Directory.GetCurrentDirectory();
            //list.Items.Add(currentDirectory);
            #endregion
        }
    }
}

//Directory.Exists();
//Directory.CreateDirectory();
//Directory.Delete();
//Directory.Move();
//Directory.GetDirectories();
//Directory.GetFiles();
//Directory.GetDirectoryRoot();
//Directory.GetLogicalDrives();
//Directory.GetParent();
//Directory.GetCurrentDirectory();