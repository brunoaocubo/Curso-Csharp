using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### FIBONACCI ###\n");
            Console.Write("Informe um valor para a sequência de números: ");
            int sequency = int.Parse(Console.ReadLine());
            List<int> fibonacci = new List<int>() {0,1};

            do
            {
                int sum = fibonacci.First();

                for (int i = 0; i < fibonacci.Count; i++)
                {
                    sum += fibonacci[i];
                }
                fibonacci.Add(sum);
            } while (fibonacci.Count < sequency);

            foreach(var item in fibonacci)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("");
        }
    }
}
