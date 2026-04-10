using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    internal class OtherClass
    {
        public double SumNumbers(double value1, double value2)
        {
            return value1 + value2;
        }

        public int IncreaseReference(ref int value)
        {
            value += 10; //Modifica o valor original, funciona também com void metodos.
            return value;
        }

        public int GetCodeChar(char character)
        {
            return character; //O metodo não depende do parametro, neste caso irá acontecer uma conversão implicita.
        }

        public double ValuePI()
        {
            return 3.1415;
        }



        #region SOBRECARGA DE MÉTODOS
        public void Greet(string name)
        {
            Console.WriteLine($"Olá, eu me chamo {name}");
        }

        public void Greet(string name, int hour)
        {
            string message = hour < 12 ? $"Bom dia, {name}" : $"Boa tarde, {name}";
            Console.WriteLine(message);
        }

        public bool Compare(int num1, int num2)
        {
            return num1 == num2;
        }

        public bool Compare(string text1, string text2)
        {
            return text1 == text2;
        }
        #endregion
    }
}

