using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Math
    {
        public void Sum(int n1, int n2)
        {
            Console.WriteLine($"Resultado da Soma: {n1 + n2}");
        }

        public void Sub(int n1, int n2)
        {
            Console.WriteLine($"Resultado da Subtração: {n1 - n2}");
        }

        public void Multi(int n1, int n2)
        {
            Console.WriteLine($"Resultado da Multiplicação: {n1 * n2}");
        }

        public void Div(int n1, int n2)
        {
            Console.WriteLine($"Resultado da Divisão: {n1 / n2}");
        }
    }
}
