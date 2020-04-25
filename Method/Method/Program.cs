using System;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            WriteSomething();
            WriteSpecificString("Text from Main Method");
            int sum = Add(4, 5);
            Console.WriteLine(sum);
            AskYourName();
            SimpleCalculate();
            Console.Read();
        }

        public static void WriteSomething()
        {
            Console.WriteLine("this is a method only write something");
        }

        public static void WriteSpecificString(string myText)
        {
            Console.WriteLine(myText);
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num1;
        }

        public static void AskYourName()
        {
            Console.WriteLine("Please enter your name!");
            string yourName = Console.ReadLine();
            Console.WriteLine("Hello " + yourName);

        }
        public static void SimpleCalculate()
        {
            Console.WriteLine("Please put the first number to add");
            string inputNumber = Console.ReadLine();
            Console.WriteLine("Please put the second number to add");
            string inputNumber2 = Console.ReadLine();

            try
            {
                int num1 = Int32.Parse(inputNumber);
                int num2 = Int32.Parse(inputNumber2);
                int sum = num1 + num2;

                Console.WriteLine("Your calculation result is " + sum);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(OverflowException e)
            {
                Console.WriteLine(e.Message);
            }
            
            finally
            {

            }
            

            
        }

        
    }
}
