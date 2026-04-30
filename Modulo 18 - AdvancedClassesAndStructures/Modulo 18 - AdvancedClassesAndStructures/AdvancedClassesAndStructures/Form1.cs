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

        private void btnTimeSpan_Click(object sender, EventArgs e)
        {
            //txtResult.Text = TimeSpan.FromHours(50).ToString();

            TimeSpan init = new TimeSpan(2, 00, 00);
            TimeSpan final = new TimeSpan(8, 00, 30);
            TimeSpan interval = final - init;
            //txtResult.Text = interval.ToString();
            //txtResult.Text = interval.TotalHours.ToString(); //Total de Horas entre o intervalo

            TimeSpan operations = init.Add(final);
            TimeSpan operations2 = init.Subtract(final);
            //txtResult.Text = operations.ToString();

            TimeSpan date1 = TimeSpan.FromDays(10);
            TimeSpan date2 = TimeSpan.FromDays(120);
            TimeSpan intervalDate = date2 - date1;
            txtResult.Text = intervalDate.ToString();
        }
    }
}
