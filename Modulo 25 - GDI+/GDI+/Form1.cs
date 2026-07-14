using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDI_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            Bitmap paper = new Bitmap(picture.Width, picture.Height);

            Graphics artist = Graphics.FromImage(paper);

            artist.Clear(Color.White);
            picture.BackgroundImage = paper;

            #region Draw Lines
            /*
            Brush pencil = new SolidBrush(Color.Red);

            Pen pen1 = new Pen(pencil, 5f);
            Point point1 = new Point(200, 200);
            Point point2 = new Point(600, 200);

            Pen pen2 = new Pen(Color.Black, 5f);
            Point point3 = new Point(600, 200);
            Point point4 = new Point(600, 350);

            //artist.DrawLine(pen1, point1, point2);
            //artist.DrawLine(pen2, point3, point4);

            Point[] points =
            {
                new Point(200, 200),
                new Point(400, 200),

                new Point(399, 200),
                new Point(200, 300),

                new Point(200, 100),
                new Point(398, 200),

            };
            artist.DrawLines(pen1, points);
            */
            #endregion

            #region Draw Rectangles
            /*
            Pen pen1 = new Pen(Color.Black, 5);
            Pen pen2 = new Pen(Color.Blue, 5);

            Rectangle rect1 = new Rectangle(50, 50, 500, 200);
            Rectangle rect2 = new Rectangle(100, 100, 500, 200);
            Rectangle rect3 = new Rectangle(300, 0, 200, 150);
            Rectangle rect4 = new Rectangle(650, 20, 100, 200);

            Rectangle[] rects =
            {
                rect1, rect2, rect3, rect4, new Rectangle(200, 50, 400, 100)
            };

            //artist.DrawRectangle(pen1, 0, 0, 500, 250);
            //artist.DrawRectangle(pen1, rect1);
            //artist.DrawRectangles(pen2, rects);

            Brush pencil1 = new SolidBrush(Color.Red);
            Brush pencil2 = new LinearGradientBrush(rect4, Color.Red, Color.DarkSalmon, 90);
            
            //artist.FillRectangle(pencil2, rect4);
            artist.FillRectangles(pencil2, rects);
            */
            #endregion

            #region Draw Ellipses/Circles
            /*
            Pen pen1 = new Pen(Color.Black, 5);
            Rectangle rect1 = new Rectangle(250, 50, 200, 200);
            Rectangle rect2 = new Rectangle(300, 200, 200, 100);


            //artist.DrawRectangle(pen1, rect1);
            //artist.DrawEllipse(pen1, rect1);

            Brush pencil = new SolidBrush(Color.Brown);

            artist.FillEllipse(Brushes.Black, rect2);
            artist.FillEllipse(pencil, rect1);
            */
            #endregion

            #region Draw Polygons
            /*
            Pen pen1 = new Pen(Color.Black, 5);

            Point[] points =
            {
                new Point(100, 100),
                new Point(200, 300),
                new Point(300, 300),
                new Point(400, 100),
            };

            Brush pencil = new SolidBrush(Color.DarkOliveGreen);
            Brush pencilGradient = new LinearGradientBrush(new Rectangle(100, 100, 200, 200), Color.Red, Color.Yellow, 90); 
            
            //artist.DrawPolygon(pen1, points);
            artist.FillPolygon(pencilGradient, points);
            */
            #endregion

            #region Draw Curves
            /*
            Pen pen1 = new Pen(Color.Black, 5);

            Point[] points =
            {
                new Point(200, 100),
                new Point(300, 250),
                new Point(400, 150),
                new Point(200, 100),
            };

            //artist.DrawCurve(pen1, points);
            //artist.DrawCurve(pen1, points, 3f);
            //artist.DrawClosedCurve(pen1, points, 1.5f, FillMode.Alternate);
            artist.FillClosedCurve(Brushes.Aqua, points, FillMode.Winding, 1.5f);
            */
            #endregion

            #region Draw Arc
            /*
            Pen pen1 = new Pen(Color.Black, 5f);
            Pen pen2 = new Pen(Color.Black, 2f);

            Rectangle rect1 = new Rectangle(100, 50, 300, 200);

            //artist.DrawRectangle(pen2, rect1);
            artist.DrawArc(pen1, rect1, 0f, 250f);
            */
            #endregion

            #region Draw Bezier
            /*
            Pen pen1 = new Pen(Color.Black, 5f);

            Point point1 = new Point(50, 200);
            Point point2 = new Point(150, 400);
            Point point3 = new Point(300, 50);
            Point point4 = new Point(600, 300);

            //artist.DrawBezier(pen1, point1, point2, point3, point4);

            Point[] points =
            {
                new Point(50, 200), // Inicio
                new Point(150, 400),
                new Point(300, 100),
                new Point(500, 200),// Meio
                new Point(600, 300), 
                new Point(700, 220),
                new Point(750, 10), // Fim
            };

            artist.DrawBeziers(pen1, points);
            */
            #endregion

            #region Draw Pie (Graphic)
            /*
            Pen pen1 = new Pen(Color.Black, 5f);
            Pen pen2 = new Pen(Color.Black, 2f);
            Rectangle rect1 = new Rectangle(50, 50, 300, 300);

            //artist.DrawPie(pen1, rect1, 270, 120);
            artist.DrawRectangle(pen2, rect1);
            artist.FillPie(Brushes.DarkRed, rect1, 270, 135);
            */
            #endregion

            #region Draw Path (Graphic)
            /*
            Pen pen1 = new Pen(Color.Black, 5);
            GraphicsPath graphicsPath = new GraphicsPath(FillMode.Alternate);

            graphicsPath.AddRectangle(new RectangleF(10, 10, 100, 150));
            graphicsPath.AddRectangle(new RectangleF(160, 10, 100, 90));
            graphicsPath.AddRectangle(new RectangleF(320, 10, 100, 150));

            artist.DrawPath(pen1, graphicsPath);
            artist.FillPath(Brushes.DarkBlue, graphicsPath);
            */
            #endregion

            #region Draw Strings

            string text = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since 1966, when designers at Letraset and James Mosley, the librarian at St Bride Printing Library in London, took a 1914 Cicero translation and scrambled it to make dummy text for Letraset's Body Type sheets. It has survived not only many decades, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised thanks to these sheets and more recently with desktop publishing software like Aldus PageMaker and Microsoft Word including versions of Lorem Ipsum.";

            Font font = new Font("Times New Roman", 15, FontStyle.Bold, GraphicsUnit.Point);
            Brush pencil = new SolidBrush(Color.Black);
            //Brush pencilGradient = new LinearGradientBrush(new Rectangle(0,0, 300, 300), Color.Aqua, Color.DarkBlue, 45);
            Point point = new Point(50, 100);
            Rectangle rect = new Rectangle(100, 100, 600, 250);
            Rectangle rect2 = new Rectangle(100, 70, 600, 30);

            StringFormat aligner = new StringFormat();
            aligner.Alignment = StringAlignment.Center;
            aligner.LineAlignment = StringAlignment.Near;
            //aligner.FormatFlags = StringFormatFlags.DirectionVertical;

            artist.DrawRectangle(new Pen(Color.Red), rect);
            artist.DrawString("Título da Página", font, pencil, rect2, aligner);
            artist.DrawString(text, font, pencil, rect, aligner);

            #endregion
            //paper.Save(@"c:\Users\bruno.carvalho\Desktop\Teste\paper.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }
    }
}
