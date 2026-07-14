using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

            #endregion


            paper.Save(@"c:\Users\bruno.carvalho\Desktop\Teste\paper.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }
    }
}
