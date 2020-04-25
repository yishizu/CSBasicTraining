using System;

namespace Logic
{

    class Program
    {
        static string userName;
        static string password;
        static void Main(string[] args)
        {
            Register();
            Login();
            Console.Read();
        }
        public static void CheckAdmin()
        {
            Console.WriteLine("Hello World!");
            bool isAdmin = false;
            bool isResigistered = true;
            string userName = "";
            Console.WriteLine("Please enter username!");
            userName = Console.ReadLine();

            /*
            if (isResigistered)
            {
                Console.WriteLine("Hi threre, registered user");
                if(userName != "")
                {
                    Console.WriteLine("Hi there, " + userName);
                    if (userName.Equals("Admin"))
                    {
                        Console.WriteLine("Hi there, Admin");
                    }
                }
            }
            */
            if (isResigistered && userName != "" && userName == "admin")
            {
                Console.WriteLine("Hi there, {0}", userName);
            }
            else if (isResigistered && userName != "")
            {
                Console.WriteLine("you are logged in!");
            }
        }
        public static void Register()
        {
            Console.WriteLine("Please enter your name");
            userName = Console.ReadLine();
            Console.WriteLine("Please enter your password");
            password = Console.ReadLine();
            Console.WriteLine("Registaratio completed!");
            Console.WriteLine("------------------------------------------");

        }

        public static void Login()
        {
            Console.WriteLine("Please enter your username");
            if (userName == Console.ReadLine())
            {
                Console.WriteLine("Please enter your passowerd");
                if(password == Console.ReadLine())
                {
                    Console.WriteLine("Login successful");
                }
                else
                {
                    Console.WriteLine("Login failed. Wrong password");
                }

            }
            else
            {
                Console.WriteLine("Login failed. Wrong username");
            }
            
        }
    }
}
