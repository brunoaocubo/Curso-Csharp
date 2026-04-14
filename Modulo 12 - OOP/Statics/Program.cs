using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region STATIC CLASSES
            /*
            MathStatic.taxe = 20;
            int value = MathStatic.Increase(200);
            int value2 = MathStatic.Decrease(200);

            Console.WriteLine(value);
            Console.WriteLine(value2);
            */
            #endregion

            Person.majority = 21;

            Person person = new Person();
            person.name = "Olivia";
            person.age = Person.CalcAge(1956);

            Console.WriteLine(person.name);
            Console.WriteLine(person.age);
            Console.WriteLine(Person.majority);
        }
    }
}
