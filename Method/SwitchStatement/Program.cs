using System;

namespace SwitchStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age");
            string age = Console.ReadLine();
            int ageNum = Int32.Parse(age);

            switch (ageNum)
            {
                case 18:
                    Console.WriteLine("You are too young");
                    break;
                case 25:
                    Console.WriteLine("You are good age");
                    break;
                default:
                    Console.WriteLine("How old are you?");
                    break;

            }

            Console.WriteLine("Please enter your name");
            string username = Console.ReadLine();

            switch (username)
            {
                case "Yuko":
                    Console.WriteLine("Your name is Yuko");
                    break;
                case "Nick":
                    Console.WriteLine("Your name is Nick");
                    break;
                default:
                    Console.WriteLine("I don know you");
                    break;
            }
            Console.Read();
        }
    }
}
