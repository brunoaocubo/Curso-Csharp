using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region SWITCH/CASE
            int value = 0;

            switch (value)
            {
                case 10:
                    Console.WriteLine("O valor está correto");
                    break;
                case 20:
                    Console.WriteLine("O valor tem uma diferença de 10");
                    break;
                case 30:
                    Console.WriteLine("O valor tem uma diferença de 20");
                    break;
                default:
                    Console.WriteLine("Nenhum valor alvo foi identificado.");
                    break;
            }
            #endregion

            #region GOTO
            
            START:
            Console.WriteLine("Selecione uma opção, (1) (2): ");
            int option = int.Parse(Console.ReadLine());
            int result = 0;

            switch (option)
            {
                default:
                    goto START;
                case 1:
                    result += 100;
                    break;
                case 2:
                    result += 50;
                    goto case 1;
            }

            Console.WriteLine($"O valor total é: {result}");
            #endregion
        }
    }
}
