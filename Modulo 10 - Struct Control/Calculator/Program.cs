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
        INIT:
            Console.Clear();
            Console.WriteLine("### CALCULADORA! ###\n");
            Console.WriteLine("--- Lista de Operações ---");
            Console.WriteLine($"({((int)options.sum)})Adição\n({(int)options.sub})Subtração\n({(int)options.multi})Multiplicação\n({(int)options.div})Divisão\n({(int)options.restdiv})Resto da Divisão\n({(int)options.potency})Potenciação\n");
            Console.Write("Selecione uma das opções acima: ");

            int option = int.Parse(Console.ReadLine());

            if(option < 1 || option > 6)
            {
                Console.WriteLine("Erro: Operação inválida\n");
                goto INIT;
            }

            Calculator(option);

            void Calculator(int opt)
            {
                double result = 0;
                Console.Write("\nDigite o primeiro valor: ");
                double value1 = double.Parse(Console.ReadLine());
                Console.Write("Digite o segundo valor: ");
                double value2 = double.Parse(Console.ReadLine());

                switch (opt)
                {
                    default:
                        break;
                    case 1:
                        result = value1 + value2;
                        break;
                    case 2:
                        result = value1 - value2;
                        break;
                    case 3:
                        result = value1 * value2;
                        break;
                    case 4:
                        result = value1 / value2;
                        break;
                    case 5:
                        result = value1 % value2;
                        break;
                    case 6:
                        result = Math.Pow(value1, value2);
                        break;
                }

                Console.WriteLine($"\nResultado: {result}");
            }

            Console.Write("\nDeseja voltar para o inicio? (s/n): ");
            char choose = char.Parse(Console.ReadLine());

            if (choose == 's' || choose == 'S') { goto INIT; }
            else {
                Console.Write("Aperte qualquer tecla para sair...");
                Console.ReadKey(); 
            }
        }
    }
}
