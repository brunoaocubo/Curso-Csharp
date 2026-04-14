using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Program
    {
        delegate void Operation(int num1, int num2);

        static void Main(string[] args)
        {
            Math math = new Math();
            Operation delegateOp = null;

            Console.WriteLine("Primeira Chamada");
            delegateOp += math.Sum; //Inscrição do delegate para utilizar o metodo Sum() de Math.
            delegateOp += math.Sub; //Mais uma atribuição ao delegate para ser utilizado.
            delegateOp += math.Multi;
            delegateOp += math.Div;
            delegateOp += math.Multi;

            delegateOp(20, 5); //Uma chamada, quatro respostas com o mesmo valor.
            Console.WriteLine("\nSegunda Chamada");
            delegateOp -= math.Div;
            delegateOp -= math.Multi;

            delegateOp(15, 10);

        }
    }
}
