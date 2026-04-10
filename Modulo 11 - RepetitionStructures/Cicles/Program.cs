using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cicles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region WHILE
            /*
            int value = 0;

            while(value < 10)
            {
                value++;
                Console.WriteLine(value);
            }
            */
            #endregion

            #region DO/WHILE
            /*
            int value = 10;

            do //Realiza a operação pelo menos uma vez e depois verifica a condição while.
            {
                value++;
                Console.WriteLine(value);

            } while (value < 15);
            */
            #endregion

            #region FOR
            /*
            for (int i = 0, j = 10; i < 10; i++, j--)
            {
                Console.WriteLine($"I: {i} | J: {j}");
            }
            */
            #endregion

            #region FOREACH
            /*
            int[] numbers = {0,9,5,8,7,6,4};

            foreach (var number in numbers)
            {
                Console.WriteLine($"Números da lista: {number}");
            }
            */
            #endregion
        }
    }
}
