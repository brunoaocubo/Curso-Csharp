using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormDetails
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void btnFormSec_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSeccondary formSeccondary = new FormSeccondary();
            formSeccondary.Message = "Teste";
            formSeccondary.ShowDialog();

            if(formSeccondary.Message != null)
            {
                mainTitle.Text = formSeccondary.Message;
            }
            this.Show();
        }

        private void btnFormSecThread_Click(object sender, EventArgs e)
        {
            this.Close();
            FormSeccondary formSeccondary = new FormSeccondary();
            formSeccondary.Message = "Teste";
            Thread thread = new Thread(() =>
            {
                Application.Run(formSeccondary);
            });

            thread.Start();
        }

        private void menuOption_NewFile_Click(object sender, EventArgs e)
        {
            new Thread(() => Application.Run(new FormMain())).Start(); 
        }

        private void menuOption_OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mHelp_Dev_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bruno Bracho");
        }

        private void mHelp_Versão_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Versão 1.0");
        }

        private void comboMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboMenu.SelectedIndex == 0)
            {
                menuFile.Text = "File";
                menuHelp.Text = "Help";
            }
            else
            {
                menuFile.Text = "Arquivo";
                menuHelp.Text = "Ajuda";
            }
        }

        private void inputSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Return)
            {
                mainTitle.Text = inputSearch.Text;
                inputSearch.Text = "";
            }
        }
    }
}
