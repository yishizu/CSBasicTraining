using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Thread_Basic
{
    class Program
    {
        static void Main(string[] args)
        {   /*
            Console.WriteLine("Hello world! 1");
            Thread.Sleep(1000);
            Console.WriteLine("Hello world! 2");
            Thread.Sleep(1000);
            Console.WriteLine("Hello world! 3");
            Thread.Sleep(1000);
            Console.WriteLine("Hello world! 4");
            
            */
            new Thread(() => 
            {
                Thread.Sleep(1000);
                Console.WriteLine("Thread 1");
            }).Start();

            new Thread(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Thread 2");
            }).Start();

            new Thread(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Thread 3");
            }).Start();

            new Thread(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Thread 4");
            }).Start();

            Console.ReadLine();
        }
    }
}
