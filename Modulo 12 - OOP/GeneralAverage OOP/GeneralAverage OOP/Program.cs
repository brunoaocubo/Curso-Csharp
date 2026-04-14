using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralAverage_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### MÉDIA GERAL DOS ALUNOS ###");
            Console.Write("\nQuantos alunos?: ");
            int qttStudents = int.Parse(Console.ReadLine());
            Student[] students = new Student[qttStudents];
            Console.Clear();

            for (int i = 0; i < students.Length; i++)
            {
            INIT:
                Console.Clear();
                try
                {
                    Console.Write($"\nNome do Aluno #{i + 1}: ");
                    string name = Console.ReadLine();
                    Console.Write("\nQuantidade de Provas: ");
                    int qttExams = int.Parse(Console.ReadLine());
                    Console.Clear();
                    students[i] = new Student(name, qttExams);
                    students[i].InsertNotes();
                    //Console.WriteLine($"\nMedia de notas do aluno, {students[i].Name}: {Math.Round(students[i].Average, 2)}");
                }
                catch
                {
                    goto INIT;
                }  
            }

            double generalAverage = 0;

            foreach (Student item in students)
            {
                generalAverage += item.Average;
                Console.WriteLine($"\nAluno: {item.Name}\nMédia: {item.Average}");
            }
            

            Console.WriteLine($"\nMédia Geral dos Alunos: {Math.Round((generalAverage / students.Length), 2)}");
        }
    }
}
