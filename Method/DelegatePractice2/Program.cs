using System;

namespace DelegatePractice2
{

    public delegate string GetTextDelegate(string name);
    public delegate double GetResultDelegate(double a, double b);
    class Program
    {
        static void Main(string[] args)
        {
            GetTextDelegate getTextDelegate = delegate (string name)
            {
                return "Hello, " + name;

            };
            

            //Lambda expression
            GetTextDelegate getHelloText = (string name) =>
            {
                return "Hello, " + name;
            };
            GetTextDelegate getGoodbyText = (string name) =>
            {
                Console.WriteLine("I'm inside of an statement lambda");
                return "Goodby, " + name;
            };

            GetTextDelegate getWelcomeText = name => "Welecome " + name;
            GetResultDelegate getSum = (a, b) => a + b;
            GetResultDelegate getProduct = (a, b) => a * b;
            Display(getTextDelegate);
            DisplayNum(getSum);
            DisplayNum(getProduct);
            Console.WriteLine(getWelcomeText("Yuko"));
        }

        static void Display(GetTextDelegate getTextDelegate)
        {
            Console.WriteLine(getTextDelegate("World"));
        }

        static void DisplayNum(GetResultDelegate getResultDelegate)
        {
            Console.WriteLine(getResultDelegate(2.0, 5.0));
        }
    }
}
