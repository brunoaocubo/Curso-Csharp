using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Car:Vehicle
    {
        private int _maxSpeed;

        public string Color { 
            get { return _color; } 
            set 
            {
                _color = value;
            } 
        }

        public string Brand
        {
            get { return _brand; }
            set
            {
                _brand = value;
            }
        }

        public int MaxSpeed
        {
            get { return _maxSpeed; }
            set
            {
                if(value > 40)
                {
                    _maxSpeed = value;
                }
                else
                {
                    Console.WriteLine("Coloque um valor de Velocidade Máxima válido.");
                }
            }
        }

        public void TurnOnCar()
        {
            Console.WriteLine("Ligou o carro!");
        }

        public override void Accelerate()
        {
            Console.WriteLine("Acelerou o carro!");
        }
    }
}
