using System;

namespace DelegatePractice
{
    class Program
    {
        public delegate double PerfomCalculation(double x , double y);
        public static double Addition(double a, double b)
        {
            Console.WriteLine("a + b is : " + (a+b));
            return a + b; 
        }

        public static double Division(double a, double b)
        {
            Console.WriteLine("a / b is : " + (a / b));
            return a / b;
        }

        public static double Subsraction(double a, double b)
        {
            Console.WriteLine("a - b is : " + (a - b));
            return a - b;
        }
        static void Main(string[] args)
        {
            PerfomCalculation getSum = Addition;
            //getSum(2.3, 4.5);
            PerfomCalculation getQuotient = Division;
            //getQuotient(5, 2);
            PerfomCalculation getSub = Subsraction;

            PerfomCalculation multiCalc = getSum + getQuotient + getSub;
            multiCalc += getSum;
            multiCalc(3.2, 3.2);
        }
    }
}
