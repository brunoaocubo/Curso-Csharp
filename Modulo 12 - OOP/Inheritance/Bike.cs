using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal sealed class Bike : Vehicle // Sealed impede que a classe seja herdada
    {
        public override void Accelerate()
        {
            Console.WriteLine("Acelerou a bicicleta");
        }

        public override void Stop()
        {
            Console.WriteLine("Parou de pedalar");
        }
    }
}
