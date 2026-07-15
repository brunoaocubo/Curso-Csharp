using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Impressão
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;

            if(printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            string text = "Trabalhando com impressão";
            Font font = new Font("Arial", 18);
            Point point = new Point(100, 50);

            e.Graphics.DrawString(text, font, Brushes.Black, point);
            e.Graphics.DrawString("Título Secundário", font, Brushes.Red, new Point(100, 100));
            e.Graphics.FillRectangle(Brushes.Red, new Rectangle(100, 200, 400, 200));
        }
    }
}
