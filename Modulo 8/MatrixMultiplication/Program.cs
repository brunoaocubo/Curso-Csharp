using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixMultiplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix1 = new int[2, 3];
            int[,] matrix2 = new int[3, 2];
            int[,] resultado = new int[2,2];

            Console.WriteLine("### Preencha a primeira matriz ###");

            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.WriteLine($"\n# Posição[{row}][{col}]:");
                    matrix1[row, col] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("### Preencha a segunda matriz ###");

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Console.WriteLine($"#Posição[{row}][{col}]:");
                    matrix2[row, col] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("### Resultado Matriz#1 x Matriz#2: ###");
            resultado[0, 0] =
                (matrix1[0,0] * matrix2[0,0]) +
                (matrix1[0,1] * matrix2[1,0]) +
                (matrix1[0,2] * matrix2[2,0]);
            
            resultado[1, 0] =(matrix1[1,0] * matrix2[0,0]) + (matrix1[1,1] * matrix2[1,0]) + (matrix1[1,2] * matrix2[2,0]);
            
            resultado[0,1] = (matrix1[0,0] * matrix2[0,1]) + (matrix1[0,1] * matrix2[1,1]) + (matrix1[0,2] * matrix2[2,1]);
            
            resultado[1,1] = (matrix1[1,0] * matrix2[0,1]) + (matrix1[1,1] * matrix2[1,1]) + (matrix1[1,2] * matrix2[2,1]);

            Console.WriteLine($"[{resultado[0, 0]}][{resultado[0, 1]}]");
            Console.WriteLine($"[{resultado[1, 0]}][{resultado[1,1]}]");

        }
    }
}
