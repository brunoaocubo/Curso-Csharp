using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double celsius, far, kelvin;
            Console.WriteLine("### CONVERSOR DE TEMPERATURA ###");
            Console.WriteLine("Digite um valor de temperatura em celsius, apenas números...");
            celsius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nConvertendo temperatura para Fahrenheit...");
            far = (celsius * 9 / 5) + 32;
            Console.WriteLine($"Temperatura em Fahrenheit: {far}ºF");

            Console.WriteLine("\nConvertendo temperatura para Kelvin...");
            kelvin = celsius + 273.15;
            Console.WriteLine($"Temperatura em Kelvin: {kelvin} K");
        }
    }
}
