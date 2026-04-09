using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace IMCCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double weight, height;
            Console.WriteLine("### CALULADORA IMC ###\n");
            Console.WriteLine("### Informe o seu peso: ###\n");
            weight = double.Parse(Console.ReadLine());

            Console.WriteLine("### Informe a sua altura: ###\n");
            height = double.Parse(Console.ReadLine());

            double resultado = weight / (height * height);
            string resposta;

            if (resultado < 18.5) { resposta = "Magreza"; }
            else if (resultado >= 18.5 || resultado <= 24.9) { resposta = "Peso Normal"; }
            else if (resultado >= 25 || resultado <= 29.9) { resposta = "Acima do Peso"; }
            else{
                resposta = "Obesidade"; 
            }

            Console.WriteLine($"Valor cálculo IMC: {resultado}\nResultado: {resposta}");
        }
    }
}
