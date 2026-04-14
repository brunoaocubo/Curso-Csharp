using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    abstract class Vehicle
    {
        public string _color;
        public string _brand;

        public abstract void Accelerate();
        public abstract void Stop();
    }
}
