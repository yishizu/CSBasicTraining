
using System;

namespace Operater
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //
            int num1 = 10;
            int num2 = 4;
            int num3;

            //unary operators
            num3 = -num1;
            Console.WriteLine("num3 is {0}", num3);

            bool isSunny = true;
            Console.WriteLine("is is sunny? {0}", isSunny);

            //increment operators
            int num = 0;
            num++;
            Console.WriteLine("num is {0}", num);
            Console.WriteLine("num is {0}", num++);
            //pre increment
            Console.WriteLine("num is {0}", ++num);

            //decrement operator
            num--;
            Console.WriteLine("num is {0}", num);
            Console.WriteLine("num is {0}", num--);
            //pre decrement 
            Console.WriteLine("num is {0}", --num);

            int result;
            result = num1 + num2;
            Console.WriteLine("result of num1 + num2 is {0}", result);

            result = num1 - num2;
            Console.WriteLine("result of num1- num2 is {0}", result);

            result = num1 / num2;
            Console.WriteLine("result of num1/num2 is {0}",result);

            result = num1 * num2;
            Console.WriteLine("result of num1*num2 is {0}", result);

            result = num1 % num2;
            Console.WriteLine("result of num1%num2 is {0}", result);

            //relational and tyepe operators
            bool isLower;
            isLower = num1 > num2;
            Console.WriteLine("result of num1> num2 is {0}", result);

            //equality operators
            bool isEqual;
            isEqual = num1 == num2;
            Console.WriteLine("result of num1 == num2 is {0}", isEqual);
            bool isNotEqual;
            isNotEqual = num1 != num2;
            Console.WriteLine("result of num1 != num2 is {0}", isNotEqual);

            //conditinal operators
            //condition1 And condition2
            bool isLowerAndSunny;
            isLowerAndSunny = isLower && isSunny;
            Console.WriteLine("result of isLower and isSunny is {0}", isLowerAndSunny);
            //condition2 or condition2
            bool isLowerOrSunny;
            isLowerOrSunny = isLower || isSunny;
            Console.WriteLine("result of isLower or isSunny is {0}", isLowerAndSunny);
            Console.Read();
        }
    }
}
