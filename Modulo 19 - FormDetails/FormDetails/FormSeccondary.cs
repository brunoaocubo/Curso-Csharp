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
    public partial class FormSeccondary : Form
    {
        public string Message { get; set; }
        public FormSeccondary()
        {
            InitializeComponent();
        }

        public FormSeccondary(string message)
        {
            this.Message = message;
        }

        private void FormSeccondary_Load(object sender, EventArgs e)
        {
            txtMessage.Text = this.Message;
        }

        private void btnFormPrincipal_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(() =>
            {
                Application.Run(new FormMain());
            });
            thread.Start();
        }

        private void btnRetorno_Click(object sender, EventArgs e)
        {
            if(txtMessage.Text == "" || txtMessage.Text == null)
            {
                Message = null;
            }
            else
            {
                Message = txtMessage.Text;
            }

            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Message = null;
            Close();
        }
    }
}
