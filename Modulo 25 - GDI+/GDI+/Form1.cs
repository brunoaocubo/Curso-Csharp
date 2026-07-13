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

            artist.Clear(Color.Blue);

            picture.BackgroundImage = paper;

            paper.Save(@"c:\Users\bruno.carvalho\Desktop\Teste\paper.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }
    }
}
