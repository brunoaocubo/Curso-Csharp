using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region VETORES
            /*
            int[] numbers = new int[5];

            numbers[0] = 2;
            numbers[1] = 3;
            numbers[2] = 4;
            numbers[3] = 5;
            numbers[4] = 6;

            string[] names = new string[2];

            names[0] = "Bruno";
            names[1] = "Rodrigo";

            string[] countries =
            {
                "EUA",
                "BRA",
                "CH"
            };

            Console.WriteLine(numbers[2]);
            Console.WriteLine(names[1]);
            Console.WriteLine(countries[1]);
            */
            #endregion

            #region VETORES BIDIMENSIONAIS

            
            int[,] numbers2 = new int[3, 3];

            numbers2[0, 0] = 10;
            numbers2[0, 1] = 20;
            numbers2[0, 2] = 30;

            numbers2[1, 0] = 40;
            numbers2[1, 1] = 50;
            numbers2[1, 2] = 60;

            double[,] mydouble =
            {
                {80, 100},
                {120, 140 }
            };

            Console.WriteLine(numbers2[1, 2]);
            Console.WriteLine(mydouble[0,1]);
            #endregion
        }
    }
}
