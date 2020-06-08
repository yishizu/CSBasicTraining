using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Thread_Alive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Thread started");
            Thread thread1 = new Thread(ThreadFunction);
            Thread thread2 = new Thread(Thread2Function);
            thread1.Start();
            thread2.Start();

            /*
            thread1.Join();
            Console.WriteLine("ThreadFunction done");
            thread2.Join();
            Console.WriteLine("Thread2Function done");
            */

            if (thread1.Join(1000))
            {
                Console.WriteLine("ThreadFunction done");
            }
            else
            {
                Console.WriteLine("ThreadFunction wasn't done within 1 sec");
            }
            thread2.Join();
            Console.WriteLine("Thread2Function done");

            if (thread1.IsAlive)
            {
                Console.WriteLine("Thread is still doing stuff");
            }
            else
            {
                Console.WriteLine("Thread 1 completed");
            }

            Console.WriteLine("Main Thread ended");
            Console.ReadLine();
        }

        public static void ThreadFunction()
        {
            Console.WriteLine("ThreadFunction started");
            Thread.Sleep(3000);
            Console.WriteLine("ThreadFunction cmoing back to caller");
        }

        public static void Thread2Function()
        {
            Console.WriteLine("Thread2Function started");
        }
    }
}
