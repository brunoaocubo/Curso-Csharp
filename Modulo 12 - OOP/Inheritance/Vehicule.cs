using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    abstract class Vehicle
    {
        protected string _color;
        protected string _brand;

        public abstract void Accelerate();

        public void Stop() {
            Console.WriteLine("Parou!");
        }
    }
}
