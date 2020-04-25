using System;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Hello World!");
            Human yuko = new Human("Yuko", "Ishizu",33,19870313);
            yuko.Greeting();
            */

            Members l = new Members();
            l.Introducing(false);
            Box b = new Box(2,4,5);

            Console.WriteLine("Box length is {0}", b.GetLength());
            b.DisplayInfo();

            b.Width = 10;
            b.DisplayInfo();
            Console.WriteLine("Box frontsurface is {0}", b.FrontSurface);
        }
    }
}
