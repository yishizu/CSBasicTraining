using System;
using System.Collections.Generic;
using System.Text;

namespace Class
{
    class Human
    {
        private string firstName;
        private string lastName;
        private int age;
        private int birthday;

        public Human(string firstName, string lastName, int age, int birthday)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.birthday = birthday;
        }

        public void Greeting()
        {
            Console.WriteLine("Hello, I am {0} {1}", firstName, lastName);
        }
    }
}
