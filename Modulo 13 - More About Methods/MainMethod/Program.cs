using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    internal class Program
    {
        //Utilizando ARGS do Main para limitar o acesso a aplicação, sendo necessário abrir pelo cmd e colocar os argumentos de entrada.
        static void Main(string[] args)
        {
            string password = "s123";

            if (args[1] != password)
            {
                Console.WriteLine("Acesso Negado");
            }
            else
            {
                Console.WriteLine($"Olá {args[0]}");
            }
        }
    }
}
