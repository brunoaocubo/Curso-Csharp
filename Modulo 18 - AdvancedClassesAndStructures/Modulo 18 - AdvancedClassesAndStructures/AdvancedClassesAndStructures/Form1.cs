using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvancedClassesAndStructures
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            //Utilizando seed para ter um ponto de partida diferente.
            Random random = new Random(DateTime.Now.Millisecond);
            int myInt = random.Next(100); //Limitar

            //Gerar valores flutuantes multicados por 100.
            double myDouble = random.NextDouble() * 100;

            txtResult.Text = $"Número gerado com Random(): {myDouble}";

        }
    }
}
