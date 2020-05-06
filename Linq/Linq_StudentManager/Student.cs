using System;
using System.Collections.Generic;
using System.Text;

namespace Linq_StudentManager
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

        //Foreing key
        public int UniversityId { get; set; }

        public void Print()
        {
            Console.WriteLine("Student {0} with Id {1}, Gender {2}"+
                " and Age {3} from University with the id {4}", Name, Id, Gender,Age,UniversityId);
        }
    }
}
