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
        // Medidas da página
        int x;
        int y;
        int width;
        int height;
        int num_lines;
        int num_pages;
        int page;

        public Form1()
        {
            InitializeComponent();
            page = 0;
            num_pages = 0;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            x = 50;
            y = 50;
            width = printDocument1.DefaultPageSettings.Bounds.Width;
            height = printDocument1.DefaultPageSettings.Bounds.Height;
            num_lines = 0;


            printDialog1.Document = printDocument1;

            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                width = printDocument1.DefaultPageSettings.Bounds.Width;
                height = printDocument1.DefaultPageSettings.Bounds.Height;
                printDocument1.PrinterSettings = printDialog1.PrinterSettings;
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
            /*
            // Título
            string title = "Título Principal";
            Font fontTitle = new Font("Times New Roman", 30, FontStyle.Underline, GraphicsUnit.Point);
            StringFormat titleAlign = new StringFormat();
            titleAlign.Alignment = StringAlignment.Center;
            titleAlign.LineAlignment = StringAlignment.Center;
            Rectangle areaTitle = new Rectangle(x, y, width - 100, 100);
            e.Graphics.DrawString(title, fontTitle, Brushes.Brown, areaTitle, titleAlign);


            // Texto
            string text = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.Lorem Ipsum has been the industry's standard dummy text ever since 1966, when designers at Letraset and James Mosley, the librarian at St Bride Printing Library in London, took a 1914 Cicero translation and scrambled it to make dummy text for Letraset's Body Type sheets. It has survived not only many decades, but also the leap into electronic typesetting, remaining essentially unchanged.It was popularised thanks to these sheets and more recently with desktop publishing software like Aldus PageMaker and Microsoft Word including versions of Lorem Ipsum.";
            Font fontText = new Font("Arial", 13, GraphicsUnit.Point);
            Rectangle areaText = new Rectangle(x + 50, y + 200, width - 100, height - 400);
            e.Graphics.DrawString(text, fontText, Brushes.Black, areaText);
            */
            #endregion

            #region Parte 3 - Impressão em Lote
            
            List<string> lines = new List<string>(){
                "1.Lorem Ipsum is simply dummy text of the printing.",
                "2.Lorem Ipsum is simply dummy text of the printing.",
                "3.Lorem Ipsum is simply dummy text of the printing.",
                "4.Lorem Ipsum is simply dummy text of the printing.",
                "5.Lorem Ipsum is simply dummy text of the printing.",
                "6.Lorem Ipsum is simply dummy text of the printing.",
                "7.Lorem Ipsum is simply dummy text of the printing.",
                "8.Lorem Ipsum is simply dummy text of the printing.",
                "9.Lorem Ipsum is simply dummy text of the printing.",
                "10.Lorem Ipsum is simply dummy text of the printing.",
                "11.Lorem Ipsum is simply dummy text of the printing.",
                "12.Lorem Ipsum is simply dummy text of the printing.",
                "13.Lorem Ipsum is simply dummy text of the printing.",
                "14.Lorem Ipsum is simply dummy text of the printing.",
                "15.Lorem Ipsum is simply dummy text of the printing.",
                "16.Lorem Ipsum is simply dummy text of the printing.",
                "17.Lorem Ipsum is simply dummy text of the printing.",
                "18.Lorem Ipsum is simply dummy text of the printing.",
                "19.Lorem Ipsum is simply dummy text of the printing.",
                "20.Lorem Ipsum is simply dummy text of the printing.",
                "21.Lorem Ipsum is simply dummy text of the printing.",
                "22.Lorem Ipsum is simply dummy text of the printing.",
                "23.Lorem Ipsum is simply dummy text of the printing.",
                "24.Lorem Ipsum is simply dummy text of the printing.",
                "25.Lorem Ipsum is simply dummy text of the printing.",
                "26.Lorem Ipsum is simply dummy text of the printing.",
                "27.Lorem Ipsum is simply dummy text of the printing.",
                "28.Lorem Ipsum is simply dummy text of the printing.",
                "29.Lorem Ipsum is simply dummy text of the printing.",
                "30.Lorem Ipsum is simply dummy text of the printing.",
                "31.Lorem Ipsum is simply dummy text of the printing.",
                "32.Lorem Ipsum is simply dummy text of the printing.",
                "1.Lorem Ipsum is simply dummy text of the printing.",
                "2.Lorem Ipsum is simply dummy text of the printing.",
                "3.Lorem Ipsum is simply dummy text of the printing.",
                "4.Lorem Ipsum is simply dummy text of the printing.",
                "5.Lorem Ipsum is simply dummy text of the printing.",
                "6.Lorem Ipsum is simply dummy text of the printing.",
                "7.Lorem Ipsum is simply dummy text of the printing.",
                "8.Lorem Ipsum is simply dummy text of the printing.",
                "9.Lorem Ipsum is simply dummy text of the printing.",
                "10.Lorem Ipsum is simply dummy text of the printing.",
                "11.Lorem Ipsum is simply dummy text of the printing.",
                "12.Lorem Ipsum is simply dummy text of the printing.",
                "13.Lorem Ipsum is simply dummy text of the printing.",
                "14.Lorem Ipsum is simply dummy text of the printing.",
                "15.Lorem Ipsum is simply dummy text of the printing.",
                "16.Lorem Ipsum is simply dummy text of the printing.",
                "17.Lorem Ipsum is simply dummy text of the printing.",
                "18.Lorem Ipsum is simply dummy text of the printing.",
                "19.Lorem Ipsum is simply dummy text of the printing.",
                "20.Lorem Ipsum is simply dummy text of the printing.",
                "21.Lorem Ipsum is simply dummy text of the printing.",
                "22.Lorem Ipsum is simply dummy text of the printing.",
                "23.Lorem Ipsum is simply dummy text of the printing.",
                "24.Lorem Ipsum is simply dummy text of the printing.",
                "25.Lorem Ipsum is simply dummy text of the printing.",
                "26.Lorem Ipsum is simply dummy text of the printing.",
                "27.Lorem Ipsum is simply dummy text of the printing.",
                "28.Lorem Ipsum is simply dummy text of the printing.",
                "29.Lorem Ipsum is simply dummy text of the printing.",
                "30.Lorem Ipsum is simply dummy text of the printing.",
                "31.Lorem Ipsum is simply dummy text of the printing.",
            };

            Font fontText = new Font("Arial", 18, GraphicsUnit.Point);
            string title = "Título Principal";
            Font fontTitle = new Font("Times New Roman", 30, FontStyle.Underline, GraphicsUnit.Point);
            Rectangle areaTitle = new Rectangle(x, y, width - 100, 100);
            StringFormat titleAlign = new StringFormat();
            titleAlign.Alignment = StringAlignment.Center;
            titleAlign.LineAlignment = StringAlignment.Center;
            
            while (num_lines < lines.Count)
            {
                if(num_lines == 0)
                {
                    e.Graphics.DrawString(title, fontTitle, Brushes.Brown, areaTitle, titleAlign);
                    y += 150;
                }

                e.Graphics.DrawString(lines[num_lines], fontText, Brushes.Black, new Point(x, y));
                y += 30;
                num_lines++;

                if(y >= height - 50)
                {
                    y = 50;
                    e.HasMorePages = true;
                    num_pages++;
                    break;
                }
            }
            
            #endregion
        }

        private void btnVisualizer_Click(object sender, EventArgs e)
        {
            x = 50;
            y = 50;
            width = printDocument1.DefaultPageSettings.Bounds.Width;
            height = printDocument1.DefaultPageSettings.Bounds.Height;
            num_lines = 0;

            printPreviewControl1.Document = printDocument1;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if(page > 0)
            {
                printPreviewControl1.StartPage = --page;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (page < num_pages)
            {
                printPreviewControl1.StartPage = ++page;
            }
        }

        private void btnVisualizerStandard_Click(object sender, EventArgs e)
        {
            x = 50;
            y = 50;
            width = printDocument1.DefaultPageSettings.Bounds.Width;
            height = printDocument1.DefaultPageSettings.Bounds.Height;
            num_lines = 0;
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();

        }
    }
}
