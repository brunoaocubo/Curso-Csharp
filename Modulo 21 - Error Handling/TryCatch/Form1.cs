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
            int[] numbers = { 10, 20, 30, 40, 50 };

            try
            {
                string s = "";

                for (int i = 0; i < 5; i++)
                {
                    s += numbers[i] + " ";
                }
                label1.Text = s;

            }
            catch (Exception ex)
            {
                label1.Text = "Erro:" + ex.Message;
            }
            finally
            {
                MessageBox.Show("Operação Finalizada. Execução de bloco finally.");
            }
        }
    }
}
