using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            Car car1 = new Car()
            {
                Color = "Vermelho",
                Brand = "Ford",
                MaxSpeed = 120

            };
            Console.WriteLine($"{car1.Color}\n{car1.Brand}\n {car1.MaxSpeed}\n");

            car1.TurnOnCar();
            car1.Accelerate();

            

            

        }
    }
}
