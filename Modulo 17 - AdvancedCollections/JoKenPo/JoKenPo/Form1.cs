using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoKenPo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRock_Click(object sender, EventArgs e)
        {
            PlayGame(0);
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            PlayGame(1);
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            PlayGame(2);
        }

        private void PlayGame(int input)
        {
            Game game = new Game();
            Result result = game.Play(input);

            pictureUser.BackgroundImage = game.ImgUser;
            picturePC.BackgroundImage = game.ImgPC;
            pictureResult.BackgroundImage = game.ImgResult(result);
        }
    }
}
