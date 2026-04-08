using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorPrecedence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double myD = 100;
            double myD2 = 10;
            double mD3 = 5;
            double result = (myD + myD2) * (mD3 / 3);

            Console.WriteLine(result);
        }
    }
}
