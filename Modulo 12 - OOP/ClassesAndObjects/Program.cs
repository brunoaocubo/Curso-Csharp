using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region SOMA COM CLASSES EXTERNAS E INTERNAS
            /*
            MyClass myclass = new MyClass();
            OtherClass otherClass = new OtherClass();

            double factorSum = 5;
            double result = otherClass.SumNumbers(myclass.Items, factorSum);
            Console.WriteLine($"Resultado da soma dos números entre classes: {result}");
            */
            #endregion

            #region OBJETOS DE CLASSE
            /*
            Person person1 = new Person();
            person1.firstName = "Andriel";
            person1.secondName = "Portugal";
            person1.born = "1978";
            person1.sex = 'M';

            Person person2 = new Person()
            {
                firstName = "Celeste",
                secondName = "Montenegro",
                born = "2000",
                sex = 'F'
            };

            Console.WriteLine(person1.firstName);
            Console.WriteLine(person2.firstName);
            */
            #endregion

            #region METODOS POR REFERÊNCIA
            /*
            OtherClass other = new OtherClass();
            int myInt = 40;

            Console.WriteLine($"Valor de myInt antes do método: {myInt}");

            other.IncreaseReference(ref myInt); //O valor de myInt vai ser aumentado devido ao Metodo de Referência.

            Console.WriteLine($"Valor de myInt depois do método: {myInt}");
            */
            #endregion

            #region RETORNOS DE VALORES
            /*
            OtherClass other2 = new OtherClass();

            char myChar = 'C';
            int codeChar = other2.GetCodeChar(myChar);

            Console.WriteLine($"Valor número da letra 'C': {codeChar}");
            Console.WriteLine($"Valor de PI: {other2.ValuePI()}");
            */
            #endregion

            #region SOBRECARGA DE MÉTODOS
            OtherClass other4 = new OtherClass();

            other4.Greet("Octavio", 15);
            other4.Greet("Octavio");

            Console.WriteLine(other4.Compare(10, 5 * 2)); // Retornará true, pois aceita expressões na passagem de parâmetros.
            Console.WriteLine(other4.Compare("Texto igual", "texto igual")); // Retornará false, pois o c# é Case Sensitive.


            #endregion
        }
    }

    /* Classe complementar interna.
    class MyClass
    {
        int items = 10;
        public int Items { get => items; 
            set {
                if ((value > 0) && (value < 100)){items = value;}
            }
        }
    }*/
}
