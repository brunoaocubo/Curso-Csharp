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
    }
}
