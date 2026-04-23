using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginSystem
{
    public partial class Home : Form
    {
        
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();

            
            while (RegisterUsers.UserLogged == null)
            {
                if (!LoginForm.cancel)
                {
                    loginForm.ShowDialog();
                }
                else
                {
                    Application.Exit();
                    return;
                }
            }  
        }
    }
}
