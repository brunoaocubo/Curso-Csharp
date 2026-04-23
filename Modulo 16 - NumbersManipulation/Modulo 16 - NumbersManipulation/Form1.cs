using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modulo_16___NumbersManipulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_execute_Click(object sender, EventArgs e)
        {
            #region TRY PARSE
            /*
            int num;

            if(int.TryParse("1985", out num))
            {
                txt_result.Text = num.ToString();
            }
            else
            {
                txt_result.Text = "Erro na Conversão";
            }
            */
            #endregion

            #region ToString
            /*
            double num = 19.96854d;
            //Formato de string para escolher o número de casas.
            txt_result.Text += num.ToString("#.00 \n");

            int myInt = 10;

            txt_result.Text += myInt.ToString("X2 \n"); // Número em hexadecimal, com minimo de 2 digitos.
            txt_result.Text += myInt.ToString("D2 \n"); // Número em decimal, com minimo de 2 digitos.
            txt_result.Text += myInt.ToString("X \n");  // Número em hexadecimal.
            txt_result.Text += myInt.ToString("D \n");  // Número em decimal.
            txt_result.Text += myInt.ToString("C \n"); // Número em Monetário.
            txt_result.Text += Convert.ToString(myInt, 8);
            */
            #endregion
        }
    }
}
