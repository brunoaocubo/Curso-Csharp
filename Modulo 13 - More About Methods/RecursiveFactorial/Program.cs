using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveFactorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número para descobrir o fatorial: ");
            int numFactor = int.Parse(Console.ReadLine());
            Console.WriteLine($"\nO fatorial de {numFactor} é: {Factorial(numFactor)}");
        }

        static int Factorial(int num)
        {
            if(num <= 0)
            {
                return 1;
            }

            return num * Factorial(num - 1);
        }
    }
}
