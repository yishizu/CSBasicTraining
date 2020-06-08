using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Thread_Pools
{
    class Program
    {
        static void Main(string[] args)
        {
            new Thread(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Thread 4");

            })
            { IsBackground = true}.Start();


            Enumerable.Range(0, 100).ToList().ForEach(f =>
            {
                ThreadPool.QueueUserWorkItem((o) =>
                {
                    Console.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} started");
                    Thread.Sleep(1000);
                    Console.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} ended");
                    
                });

                
            });

            Console.ReadLine();
        }
        
    }
}
