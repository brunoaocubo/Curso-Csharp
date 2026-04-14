using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonCTT person = new PersonCTT("Samantha", "Benford", 2008);

            PersonCTT person2 = new PersonCTT("Paola", "Bracho");

            Console.WriteLine($"{person.firstName}\n{person.lastName}\n{person.bornYear}\n{person.age}");

            Console.WriteLine($"\n{person2.firstName}\n{person2.lastName}\n{person2.bornYear}\n{person2.age}");
        }
    }
}
