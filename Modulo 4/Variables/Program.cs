using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class Program
    {
        enum Notas
        {
            Min = 10,
            Med = 20,
            Max = 30
        }

        struct Pessoa
        {
            public string nome;
            public long tel;
            public char sexo;
        }

        static void Main(string[] args)
        {
            #region NÚMEROS INTEIROS
            /*
            //INTEGRAL ASSINADO
            sbyte mySbyte = 10; // 8 bits, de -128 a 127
            short myShort = 20; // 16 bits, -32.768 a 32.767
            int myInt = 30; // 32 bits, -2.147.483.648 a 2.147.483.647 
            long myLong = 40L; // 64 bits, -9.223.372.036.854.775.808 a 9.223.372.036.854.775.807

            //INTEGRAL SEM SINAL
            byte myByte = 10; // 8 bits, intervalo de 0 a 255
            ushort Ushort = 20; // 16bits, 0 a 65.535
            uint Uint = 30; // 32 bits, 0 a 4.294.967.295
            ulong Ulong = 40L; // 64 bits, 0 a 18.446.744.073.709.551.615 */
            #endregion

            #region NÚMEROS REAIS
            /*
            float myFloat = 100.75f; // 32 bits,
            double myDouble = 12500.85; // 64 bits,
            decimal myDecimal = 752985648.999m; // 128 bits,
            */
            #endregion

            #region CARACTERE
            /*
            char myChar = '\u0061'; // Atribuição com aspas simples ('')
            char escape = '\n';
            char literal = 'C';
            */
            #endregion

            #region BOOLEAN
            /*
            bool myBool = false; // 1 bit, true ou false.
            myBool = true;
            */
            #endregion

            #region STRING
            /*
            string myString = @"Hello \n World".; // Atribuição com aspas duplas ("")
            string messageString = null;
            messageString = myString;
            */
            #endregion

            #region TIPO IMPLICITO VAR
            /*
            // O tipo é definido na primeira referência.
            var myVar = 100;
            myVar = 20;

            // String para Int não funciona.
            myVar = "Tentando Atribuir string";
            */
            #endregion

            #region OBJECT
            /*
            //object é a base para todos os outros tipos de valores. Porém não pode ser usada para operações matemáticas diretamente, mas sim para referências de objetos.
            object obj = false;
            obj = 200;
            obj = "Teste";
            */
            #endregion

            #region CONSTANTES
            /*
            //Valor fixo na declaração, não pode ser reatribuido/alterado.
            const int myInt = 1000;
            const string nome = "Bruno";

            myInt = 20; // Não é possível atribuir um novo valor
            */
            #endregion

            #region ENUMERAÇÕES

            //Coleção de valores personalizados para ser utilizado na aplicação, dependendo do caso de uso é muito útil para valores pre-determinados.
            Notas notasAlunos = Notas.Min;

            #endregion

            #region STRUCT
            /*
            Pessoa pessoa1 = new Pessoa();
            pessoa1.nome = "Bruno";
            pessoa1.sexo = 'M';
            pessoa1.tel = 71998656490;

            Console.WriteLine($"{pessoa1.nome}\n{pessoa1.sexo}\n{pessoa1.tel}");
            */
            #endregion

            Console.WriteLine();
        }
    }
}
