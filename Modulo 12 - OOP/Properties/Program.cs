using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetSet person = new GetSet();

            person.Name = "Sophia";
            person.Age = 17;

            Console.WriteLine(person.Name + " " + person.LastName);
            Console.WriteLine(person.Age);
        }
    }
}
