using System;
using System.Collections.Generic;
using System.Text;

namespace Linq_StudentManager
{
    class University
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Print()
        {
            Console.WriteLine("Univeresity {0} with id {2}", Id,Name);

        }

    }
}
