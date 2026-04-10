using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    internal class Person
    {
        public string firstName;
        public string secondName;
        public string born;
        public char sex;

        public void Greet()
        {
            Console.WriteLine("Olá, prazer em te conhecer!");
        }
    }
}
