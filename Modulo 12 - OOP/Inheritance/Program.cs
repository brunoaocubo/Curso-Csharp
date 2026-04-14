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
            #region HERANÇA - CLASSE SEALED
            /*
            Car car1 = new Car()
            {
                _color = "Vermelho",
                _brand = "Ford",
                MaxSpeed = 120
            };

            Console.WriteLine($"{car1._color}\n{car1._brand}\n {car1.MaxSpeed}\n");

            car1.TurnOnCar();
            car1.Accelerate();
            car1.Stop();

            Console.WriteLine("\n");

            Bike bike = new Bike()
            {
                _color = "Verde",
                _brand = "XRX"
            };

            bike.Accelerate();
            bike.Stop();
           */
            #endregion

            #region MEMBROS SEALED
            Human human = new Human();
            Person person = new Person();
            Man man = new Man();

            Console.WriteLine("\nHumano:");
            human.Eyes();
            human.Hair();

            Console.WriteLine("\nPessoa:");
            person.Eyes();
            person.Hair();

            Console.WriteLine("\nHomem:");
            man.Eyes();
            man.Hair();
            #endregion

        }
    }
}
