using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_InvertNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva um nome:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Escreva um segundo nome:");
            string secondName = Console.ReadLine();
            string varTochange;
            varTochange = firstName;
            firstName = secondName;
            secondName = varTochange;

            Console.WriteLine($"O primeiro nome: {firstName}\nO segundo nome: {secondName}");
            
        }
    }
}
