using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal sealed class Truck  : Car // Sealed impede que a classe seja herdada
    {
        public bool extendedCab { get; set; }
    }
}
