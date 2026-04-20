using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringManipulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            #region CONTAINS / ToString
            /*
            string text = "Este texto é do tipo string";

            if (text.Contains("tipo"))
            {
                textResult.Text = "Contém.";
            }
            else
            {
                textResult.Text = "Não Contém.";
            }
            
            int num = 9000;

            //Tentativa de conversão de int para string.
            textResult.Text = num.ToString(); 
            */
            #endregion

            #region TOUPPER/TOLOWER
            /*
            string name = "Bruno Montenegro";

            //textResult.Text = name.ToUpper();
            textResult.Text = name.ToLower();
            */
            #endregion


        }
    }
}
