using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TryCatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int[] numbers = { 10, 20, 30, 40, 50 };
                string s = "";
                for (int i = 0; i < 6; i++)
                {
                    s += numbers[i] + " ";
                }

            }
            catch (Exception ex)
            {
                label1.Text = "Erro:" + ex.Message;
            }
        }
    }
}
