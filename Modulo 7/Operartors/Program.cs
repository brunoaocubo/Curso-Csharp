using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operartors
{
    internal class Program
    {

        static void Main(string[] args)
        {
            #region INCREMENTO/DECREMENTO
            /*
            int num1 = 10;
            num1++;
            ++num1;
            num1--;
            --num1;

            Console.WriteLine(num1--);
            */
            #endregion;

            #region CONCATENAÇÃO
            /*
            string firstName = "Bruno ";
            string secondName = "Porto";
            string fullname = firstName + secondName;

            Console.WriteLine(fullname);
            */
            #endregion

            #region ATRIBUIÇÃO
            /*
            //int num2 = 20;
            //num2 += 20;
            //num2 -= 2;
            //num2 *= 3;
            //num2 /= 2;
            //num2 %= 2;

            string nome = "Bruno ";
            nome += "Portugal";

            Console.WriteLine(nome);
            */
            #endregion

            #region IGUALDADE/COMPARAÇÃO
            /*
            bool res = 100 == (50 * 2);
            bool res2 = (200 /2) != (100 + 100);

            string nome = "Bruno";
            bool res3 = nome == "Bruno";

            Console.WriteLine(res2);
            */
            #endregion

            #region RELACIONAL
            /*
            bool res = 100 < (50 + 65);
            bool res2 = (100 + 25) > (50 * 2);
            bool res3 = 100 <= (50 * 2);
            bool res4 = 75 >= 50;

            Console.WriteLine($"res: {res}\n res2:{res2} \n res3:{res3} \n res4:{res4}");
            */
            #endregion

            #region OPERADORES LÓGICOS

            bool res1 = 100 > 50;
            bool res2 = 50 != 50;
            bool final = res1 && res2;
            bool final2 = res1 || res2;


            Console.WriteLine("Resultado 1: "+ final + "\n" + "Resultado 2: " + final2);
            #endregion
        }
    }
}