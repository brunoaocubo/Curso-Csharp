using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region TASK
            /*
            Task task = new Task(TaskToExecute);
            task.Start();
            Task.Run(TaskToExecute);

            Task.Factory.StartNew(TaskToExecute);

            Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Tarefa thread secundaria!");
                }
            });

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Tarefa thread principal!");
            }
            */
            #endregion

            #region Array Task e Task.WaitAll()
            /* Criar Tasks dentro de array; Utilizando Task.WaitAll() para aguardar a conclusão de todas elas.
            Task[] tasks =
            {
                Task.Factory.StartNew(()=> 
                {
                    Console.WriteLine("Tarefa1");

                }),
                Task.Factory.StartNew(()=>
                {
                    Console.WriteLine("Tarefa2");

                }),
                Task.Factory.StartNew(()=>
                {
                    Console.WriteLine("Tarefa3");

                })
            };

            Task.WaitAll(tasks);
            */

            /* Task.WaitAll() sem utilizar array.
            Task t1 = Task.Run(()=>{    Console.WriteLine("Tarefa Anonima1");    });
            Task t2 = Task.Run(() => { Console.WriteLine("Tarefa Anonima2"); });
            Task t3 = Task.Run(() => { Console.WriteLine("Tarefa Anonima3"); });

            Task.WaitAll(t1, t2, t3);
                
            Console.WriteLine("Tarefa Principal");

            Console.ReadKey();*/
            #endregion

            #region Task Callbacks, Task ContinueWith (TPL)
            Task<int> task = Task.Run(() => { return Sum(5, 9); });

            Task<double> calcTask = task.ContinueWith((num) =>
            {
                double result = num.Result * 10;
                return result;
            });

            Task<string> messageTask = calcTask.ContinueWith((calc) =>
            {
                string message = $"O valor final é: {calc.Result}";
                return message;
            });

            Console.WriteLine(messageTask.Result);

            Console.ReadKey();
            #endregion
        }

        static int Sum(int n1, int n2)
        {
            return n1 + n2;
        }

        static private void TaskToExecute()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Tarefa sendo executada!");
            }
        }
    }
}