using System;

namespace CalculationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            int count = 0;
            int total = 0;
            double average = 0;
            int currentNumber = 0;
            Console.WriteLine("Welcome to calculation app");
            while(input != -1)
            {
                Console.WriteLine("the current number is {0}", currentNumber);
                Console.WriteLine("the score count is {0}",count);
                Console.WriteLine("the score total is {0}", total);
                Console.WriteLine("Please enter -1 to start calculation");
                Console.WriteLine("Please input the score");

                string inputString = Console.ReadLine();
                if (inputString.Equals("-1"))
                {
                    average = (double)total / (double)count;
                    Console.WriteLine("the average number is {0}", average);
                    break;
                }
                if (Int32.TryParse(inputString, out currentNumber) && currentNumber>0 && currentNumber<21)
                {
                    total += currentNumber;
                    count++;
                }
                else
                {
                    if(currentNumber!= -1)
                    {
                        Console.WriteLine("Please enter the number between 1 to 20");
                        continue;
                    }
                    
                }


            }
            
        }
    }
}
