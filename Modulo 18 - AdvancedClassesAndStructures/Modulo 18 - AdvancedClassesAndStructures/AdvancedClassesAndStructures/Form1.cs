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

        private void btnDateTime_Click(object sender, EventArgs e)
        {
            //txtResult.Text = DateTime.Now.ToString();
            txtResult.Text = DateTime.Today.ToString();
            txtResult.Text = DateTime.UtcNow.ToString();
            txtResult.Text = DateTime.DaysInMonth(2024, 2).ToString();
            txtResult.Text = DateTime.IsLeapYear(2024).ToString(); //Ano bisexto
            txtResult.Text = DateTime.Now.ToLongDateString().ToString(); //Data longa
            txtResult.Text = DateTime.Now.ToShortDateString().ToString(); //Data curta
            txtResult.Text = DateTime.Now.ToLongTimeString().ToString();
            txtResult.Text = DateTime.Now.ToUniversalTime().ToString();
            txtResult.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            DateTime date = new DateTime(2002, 06, 15, 00, 52,33);
            
            txtResult.Text = date.DayOfWeek.ToString(); //Dia daquela data
            txtResult.Text = date.DayOfYear.ToString(); //Dia daquele ano

            TimeSpan timeSpan = new TimeSpan(1, 00, 00);
            txtResult.Text = date.Add(timeSpan).ToString(); //Adicionar tempo na data a partir de um timeSpan.
            txtResult.Text = date.AddYears(22).ToString(); //Adicionar anos na data.
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            Color color = Color.Yellow;
            Color color1 = Color.FromArgb(90, Color.DarkOrange);
            Color color2 = Color.FromArgb(200, 150, 196);
            Color color3 = Color.FromArgb(255, 220, 150, 196);
            Color color4 = Color.FromName("Blue");

            Color color5 = Color.FromKnownColor(KnownColor.DarkRed);

            txtResult.ForeColor = color1;
            txtResult.BackColor = color3;
            btnColor.BackColor = txtResult.ForeColor = color5;
        }
    }
}
