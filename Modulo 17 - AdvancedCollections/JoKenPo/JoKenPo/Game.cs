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
        private Dictionary<int, Image> imagesMecanics = new Dictionary<int, Image>()
        {
            { 0, Image.FromFile("imagesMecanics/Pedra.png")},
            { 1, Image.FromFile("imagesMecanics/Papel.png")},
            { 2, Image.FromFile("imagesMecanics/Tesoura.png")}
        };

        private Dictionary<Result, Image> imagesResult = new Dictionary<Result, Image>()
        {
            {Result.Draw, Image.FromFile("imagesResult/Empatar.png")},
            {Result.Loose, Image.FromFile("imagesResult/Perder.png")},
            {Result.Win, Image.FromFile("imagesResult/Ganhar.png")}
        };

        public Image ImgPC { get; private set; }
        public Image ImgUser { get; private set; }

        public Result Play(int inputUser) {
            ImgUser = imagesMecanics[inputUser];

            int inputPC = PlayPC();

            if (inputUser == inputPC)
            {
                return Result.Draw;
            }

            if (inputUser == 0 && inputPC == 2)
            {
                return Result.Win;
            }
            else if (inputUser == 1 && inputPC == 0)
            {
                return Result.Win;
            }
            else if (inputUser == 2 && inputPC == 1)
            {
                return Result.Win;
            }
            else
            {
                return Result.Loose;
            }
        }
        
        private int PlayPC()
        {
            Random random = new Random();
            int number = random.Next(0, 3);
            ImgPC = imagesMecanics[number];
            return number;
        }

        public Image ImgResult(Result result) 
        {
            return imagesResult[result];
        }
    }
}
