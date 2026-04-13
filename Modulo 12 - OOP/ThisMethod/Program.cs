using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Acess acess = new Acess();

            if (acess.Login("123"))
            {
                Console.WriteLine("Login com sucesso!");
            }
            else
            {
                Console.WriteLine("Falha no login: Senha Incorreta!");
            }
        }
    }
}
