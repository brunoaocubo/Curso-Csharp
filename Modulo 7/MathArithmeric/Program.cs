using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathArithmeric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ADIÇÃO

            int myInt1 = 0;
            myInt1 = myInt1 + 1;
            Console.WriteLine($"Resultado Adição: {myInt1}");

            #endregion

            #region SUBTRAÇÃO

            int myInt2 = 20;
            myInt2 = myInt2 - 1;
            Console.WriteLine($"Resultado Subtração: {myInt2}");

            #endregion

            #region MULTIPLICAÇÃO

            double myDouble1 = 10;
            myDouble1 = myDouble1 * 10;
            Console.WriteLine($"Resultado Multiplicação: {myDouble1}");

            #endregion

            #region DIVISÃO

            double myDouble2 = 10;
            myDouble2 = myDouble2 / 2;
            Console.WriteLine($"Resultado Divisão: {myDouble2}");

            #endregion

            #region RESTO DA DIVISÃO

            double myDouble3 = 15;
            myDouble3 = myDouble3 % 2;
            Console.WriteLine($"Resultado Resto da Divisão: {myDouble3}");

            #endregion
        }
    }
}
