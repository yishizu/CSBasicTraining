using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Class
{
    class Members
    {
        //
        private string memeberName;
        private string jobTitle;
        private int salary;

        public int age;

        public Members()
        {
            age = 30;
            memeberName = "Lucy";
            salary = 600000;
            jobTitle = "Developer";
            Console.WriteLine("Object created");
        }
        public string JobTitle
        {
            get
            {
                return jobTitle;
            }
            set
            {
                jobTitle = value;
            }
        }

        public void Introducing(bool isFriend)
        {
            if (isFriend)
            {
                SharingPrivateInfo();
            }
            else
            {
                Console.WriteLine("Hi my name is {0}. I am {1} years old. My job is {2}",memeberName,age,jobTitle);
            }
        }

        private void SharingPrivateInfo()
        {
            Console.WriteLine("Hi, My salary is {0}",salary);

        }
        ~Members()
        {
            // clean up the statements
            Console.WriteLine("Deconstruction of Member objects");
            Debug.Write("Deconstruction of Member objects");
        }
    }
}
