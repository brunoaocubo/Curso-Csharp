using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoKenPo
{
    public enum Result
    {
         Win, Loose, Draw
    }

    internal class Game
    {
        private Image[] imagesMecanics =
        {
            Image.FromFile("images/imagesMecanics/Pedra.png"),
            Image.FromFile("images/imagesMecanics/Papel.png"),
            Image.FromFile("images/imagesMecanics/Tesoura.png")
        };

        private Image[] imagesResult =
        {
            Image.FromFile("images/imagesResult/Empatar.png"),
            Image.FromFile("images/imagesResult/Perder.png"),
            Image.FromFile("images/imagesResult/Ganhar.png")
        };

        public Image ImgPC { get; private set; }
        public Image ImgUser { get; private set; }


        public Result Play() {
            
            return Result.Draw;
        }

        private void PlayUser(Result result)
        {
            Random random = new Random();
            int number = random.Next(0, 3);
            //int number = 
            if(result == Result.Win)
            {
                //return images
            }
        }

        private void PlayMachine()
        {

        }

    }
}
