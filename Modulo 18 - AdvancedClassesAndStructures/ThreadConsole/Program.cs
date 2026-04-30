using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(new ThreadStart(ExecuteTask));
            thread.IsBackground = true; // Encerra a thread se a thread principal estiver finalizado.
            thread.Join(); //Bloqueia a thread principal, Main(), até ExecuteTask() esteja finalizado.
            thread.Start();


            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Principal Thread");
                Thread.Sleep(500);
            }

            Console.ReadKey();
        }

        static void ExecuteTask()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Tarefa executada.");
                Thread.Sleep(1000);
            }
        }
    }
}
