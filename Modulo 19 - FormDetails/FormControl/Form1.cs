using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormControl
{
    public partial class Form1 : Form
    {
        Label label1;
        Button btn1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1 = new Label();
            label1.Location = new Point(100, 50);
            label1.AutoSize = false;
            label1.Size = new Size(500, 200);
            label1.BackColor = Color.Black;
            label1.ForeColor = Color.White;
            label1.Font = new Font("Arial", 25, FontStyle.Bold, GraphicsUnit.Point);
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Text = "teste";

            btn1 = new Button();
            btn1.Location = new Point(250, 250);
            btn1.AutoSize = false;
            btn1.Size = new Size(150, 75);
            btn1.BackColor = Color.Red;
            btn1.ForeColor = Color.Black;
            btn1.Font = new Font("Arial", 10, FontStyle.Bold, GraphicsUnit.Point);
            //btn1.TextAlign = ContentAlignment.MiddleCenter;
            btn1.Text = "Executar";
            btn1.MouseEnter += Btn1_MouseEnter;
            btn1.MouseLeave += Btn1_MouseLeave;
            btn1.Click += Btn1_Click;

            this.Controls.Add(label1);
            this.Controls.Add(btn1);
        }

        private void Btn1_MouseLeave(object sender, EventArgs e)
        {
            btn1.Cursor = Cursors.Default;
           
        }

        private void Btn1_MouseEnter(object sender, EventArgs e)
        {
            btn1.Cursor = Cursors.Hand;

        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            label1.Text = "O botão foi clicado";
        }
    }
}
