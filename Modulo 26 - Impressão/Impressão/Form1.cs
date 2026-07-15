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
            #region Parte 1 - Imprimindo o documento
            /*
            string text = "Trabalhando com impressão";
            Font font = new Font("Arial", 18);
            Point point = new Point(100, 50);

            e.Graphics.DrawString(text, font, Brushes.Black, point);
            e.Graphics.DrawString("Título Secundário", font, Brushes.Red, new Point(100, 100));
            e.Graphics.FillRectangle(Brushes.Red, new Rectangle(100, 200, 400, 200));
            */
            #endregion

            #region Parte 2 - Formatando o documento
            // Medidas da página
            int x = printDocument1.DefaultPageSettings.Bounds.X;
            int y = printDocument1.DefaultPageSettings.Bounds.Y;
            int width = printDocument1.DefaultPageSettings.Bounds.Width;
            int height = printDocument1.DefaultPageSettings.Bounds.Height;


            // Título
            string title = "Título Principal";
            Font fontTitle = new Font("Times New Roman", 30, FontStyle.Underline, GraphicsUnit.Point);
            StringFormat titleAlign = new StringFormat();
            titleAlign.Alignment = StringAlignment.Center;
            titleAlign.LineAlignment = StringAlignment.Center;
            Rectangle areaTitle = new Rectangle(x + 50, y + 100, width - 100, 100);
            e.Graphics.DrawString(title, fontTitle, Brushes.Brown, areaTitle, titleAlign);


            // Texto
            string text = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.Lorem Ipsum has been the industry's standard dummy text ever since 1966, when designers at Letraset and James Mosley, the librarian at St Bride Printing Library in London, took a 1914 Cicero translation and scrambled it to make dummy text for Letraset's Body Type sheets. It has survived not only many decades, but also the leap into electronic typesetting, remaining essentially unchanged.It was popularised thanks to these sheets and more recently with desktop publishing software like Aldus PageMaker and Microsoft Word including versions of Lorem Ipsum.";
            Font fontText = new Font("Arial", 13, GraphicsUnit.Point);
            Rectangle areaText = new Rectangle(x + 50, y + 200, width - 100, height - 400);
            e.Graphics.DrawString(text, fontText, Brushes.Black, areaText);
            #endregion

        }
    }
}
