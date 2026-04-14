using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace GeneralAverage_OOP
{
    internal class Student
    {
        public string Name { get; private set; }
        private double[] notes = new double[3];

        public double Average
        {
            get
            {
                return CalcAverage();
            }
        }

        public Student(string name, int exam)
        {
            Name = name;
            notes = new double[exam];
        }

        public void InsertNotes()
        {
            for (int i = 0; i < notes.Length; i++)
            {
            INIT:
                Console.Write($"Insira o valor da prova {i + 1}: ");
                double note = double.Parse(Console.ReadLine());

                if(note < 0 || note > 10)
                {
                    Console.WriteLine("ERRO: é permitido apenas valores entre 0 e 10\n");
                    goto INIT;
                }

                notes[i] = note;

                if (i >= notes.Length)
                {
                    GetNotes();
                }
            }
        }

        private double CalcAverage()
        {
            double sum = 0;

            foreach (double item in notes)
            {
                sum += item;
            }

            return Math.Round((sum / notes.Length), 2);
        }

        public void GetNotes()
        {
            Console.WriteLine($"Quantidade de Provas: {notes.Length}");

            foreach (var item in notes)
            {
                Console.WriteLine($"Nota: {item}");
            }
        }
    }
}
