using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        enum options
        {
            sum = 1,
            sub = 2,
            multi = 3,
            div = 4,
            restdiv = 5,
            potency = 6
        }

        static void Main(string[] args)
        {
            double sum, sub, multi, div, restdiv, potency;

            INIT:
            Console.WriteLine("### CALCULADORA! ###\n");
            Console.WriteLine("Selecione uma das operações abaixo: ");
            Console.WriteLine($"({((int)options.sum)})Adição\n({(int)options.sub})Subtração\n({(int)options.multi})Multiplicação\n({(int)options.div})Divisão\n({(int)options.restdiv})Resto da Divisão\n({(int)options.potency})Potenciação\n");
            
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                default:
                    goto INIT;
                case 1:

                    break;
            }

        }
    }
}
