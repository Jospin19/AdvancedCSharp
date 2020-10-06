using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace TaskParallelLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            var source = new CancellationTokenSource();
            try
            {
                var t1 = Task.Factory.StartNew(() => DoSomeVeryImportantWork(1, 1500, source.Token)).ContinueWith((prevTask) => DoSomeOtherVeryImportantWork(1, 1200, source.Token));
                source.Cancel();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.GetType());
            }
            


            //var intList = new List<int> { 1, 2, 45, 6, 78, 65, 23, 48, 79, 67, 10, 95 };

            //Parallel.ForEach(intList, (i) => { Console.WriteLine(i); });
            //var t1 = Task.Factory.StartNew(() => DoSomeVeryImportantWork(1, 1500));

            //var t2 = Task.Factory.StartNew(() => DoSomeVeryImportantWork(2, 3000));

            //var t3 = Task.Factory.StartNew(() => DoSomeVeryImportantWork(3, 1000));

            //var taskList = new List<Task> { t1, t2, t3 };
            //Task.WaitAll(taskList.ToArray());

            //for(var i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Do some other work : ");
            //    Thread.Sleep(250);
            //    Console.WriteLine($"var i = {i}");
            //}

            //Console.WriteLine("Press any key to quit..");
            //Console.ReadKey();
        }

        static void DoSomeVeryImportantWork(int id, int SleepTime, CancellationToken token)
        {
            if(token.IsCancellationRequested)
            {
                Console.WriteLine("Cancellation requested");
                token.ThrowIfCancellationRequested();
            }

            Console.WriteLine($"task {id} is begining");
            Thread.Sleep(SleepTime);
            Console.WriteLine($"task {id} has completed");
        }

        static void DoSomeOtherVeryImportantWork(int id, int SleepTime, CancellationToken token)
        {
            if (token.IsCancellationRequested)
            {
                Console.WriteLine("Cancellation requested");
                token.ThrowIfCancellationRequested();
            }
            Console.WriteLine($"task {id} is begining more work");
            Thread.Sleep(SleepTime);
            Console.WriteLine($"task {id} has completed more work");
        }
    }
}
