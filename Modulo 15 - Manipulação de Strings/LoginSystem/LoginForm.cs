using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginSystem
{
    public partial class LoginForm : Form
    {
        public static bool cancel;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            User user = new User() { Username = userInput.Text, Password = passwordInput.Text};

            if(RegisterUsers.Login(user))
            {
                cancel = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário e/ou senha incorreto(s)");

                userInput.Text = "";
                passwordInput.Text = "";
                userInput.Focus();
                cancel = false;
            }
        }

        private void btn_closed_Click(object sender, EventArgs e)
        {
            cancel = true;
            Close();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            cancel = true;
        }
    }
}
