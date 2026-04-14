using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statics
{
    partial class Person
    {
        public void Greets()
        {
            Console.WriteLine($"Olá me u chamo {age}");
        }

        public static int CalcAge(int bornYear)
        {
            return DateTime.Now.Year - bornYear;
        }
    }
}
