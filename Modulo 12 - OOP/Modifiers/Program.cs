using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Classes teste = new Classes();
            //teste.name = ; Modficador Private
            teste.lastName = ""; 
            //teste.Method1(); Modficador Private
            teste.Method2();
        }
    }
}
