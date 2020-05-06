using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;

namespace Linq_StudentManager
{
    class UniversityManager
    {
        public List<University> universities;
        public List<Student> students;

        public UniversityManager()
        {
            universities = new List<University>();
            students = new List<Student>();

            universities.Add(new University { Id = 1, Name = "Yale" });
            universities.Add(new University { Id = 2, Name = "Ethz" });

            students.Add(new Student { Id = 1, Name = "Carla", Gender = "female", Age = 17, UniversityId = 1 });
            students.Add(new Student { Id = 2, Name = "Linda", Gender = "female", Age = 47, UniversityId = 2 });
            students.Add(new Student { Id = 3, Name = "Yuko", Gender = "female", Age = 52, UniversityId = 1 });
            students.Add(new Student { Id = 4, Name = "Haris", Gender = "trans-gender", Age = 23, UniversityId = 2 });
            students.Add(new Student { Id = 5, Name = "James", Gender = "male", Age = 33, UniversityId = 1 });
            students.Add(new Student { Id = 6, Name = "Mike", Gender = "male", Age = 35, UniversityId = 2 });
        }

        public void MaleStudents()
        {
            IEnumerable<Student> maleStudents = from student in students where student.Gender == "male" select student;
            Console.WriteLine("Male - Sudents:");
            foreach(var student in maleStudents)
            {
                student.Print();
            }
        }

        public void FemaleStudents()
        {
            IEnumerable<Student> femaleStudents = from student in students where student.Gender == "female" select student;
            Console.WriteLine("Female - Sudents:");
            foreach (var student in femaleStudents)
            {
                student.Print();
            }
        }

        public void SortStudentByAge()
        {
            var sortedStudents = from student in students orderby student.Age select student;
            Console.WriteLine("Student sorted by Age:");
            foreach (var student in sortedStudents)
            {
                student.Print();
            }
        }

        public void AllStudentsFromThatUni(int Id)
        {
            IEnumerable<Student> myStundents = from student in students
                                               join university in universities on student.UniversityId equals university.Id
                                               where university.Id == Id
                                               select student;

            Console.WriteLine("Students from taht uni {0}", Id);
            foreach (Student student in myStundents)
            {
                student.Print();
            }

        }

        public void StudentAndUniversityNameCollocetion()
        {
            var newCollection = from student in students
                                join university in universities on student.UniversityId equals university.Id
                                orderby student.Name
                                select new { StudentName = student.Name, UniversityName = university.Name };
            Console.WriteLine("New Collection:");
            foreach (var col in newCollection)
            {
                Console.WriteLine("Student {0} from University {1}", col.StudentName, col.StudentName);
            }
        }
    }
}
