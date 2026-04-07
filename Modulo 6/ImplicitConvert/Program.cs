using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace ConvertTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region IMPLICIT CONVERT         
            /*
             * BYTE > USHORT
            byte myByte = 10; //8 bits, armazena de 0 a 255
            ushort myUshort; //15 bits, 0 a 65.535
            myUshort = myByte; // A linguagem permite pois o computador entende que o valor contido em myByte cabe perfeitamente na variavel ushort.
            
            //FLOAT > DOUBLE
            float myFloat = 50.9f;
            double myDouble;
            myDouble = myFloat;

            //CHAR > INT
            int numberOfChar = 'C';
            
            Console.WriteLine(myUshort);
            Console.WriteLine(myDouble);
            Console.WriteLine(numberOfChar);
            */
            #endregion

            #region EXPLICIT CONVERT

            /*Para atribuir uma variavel que possui um tamanho máximo maior, é preciso de maneira explicita informar o tipo que deseja. 
             * Caso o valor ainda assim seja maior, ele não impedirá de transformar, porém você terá perda de dados.
            */

            ushort ushort2 = 500;
            byte byte2 = (byte)ushort2; //Perda de dados. O valor é maior do que o espaço disponível.

            double myD = 506954.54;
            float myFloat = (float)myD;

            char letter = (char)97;

            #endregion

            Console.WriteLine(letter);
        }
    }
}
