using System;
using System.Linq;
using System.Xml.Linq;

namespace Linq_WithXml
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            string studentsXML =
                @"<Students>
                    <Student>
                        <Name>Toni</Name>
                        <Age>21</Age>
                        <University>Yale</University>
                        <Semister>6</Semister>
                    </Student>
                    <Student>
                        <Name>Yuko</Name>
                        <Age>33</Age>
                        <University>Kobe</University>
                        <Semister>6</Semister>
                    </Student>
                    <Student>
                        <Name>James</Name>
                        <Age>32</Age>
                        <University>Ethz</University>
                        <Semister>6</Semister>
                    </Student>
                </Students>";
            XDocument studentsXdoc = new XDocument();
            studentsXdoc = XDocument.Parse(studentsXML);

            var students = from student in studentsXdoc.Descendants("Student")
                           select new
                           {
                               Name = student.Element("Name").Value,
                               Age = student.Element("Age").Value,
                               University = student.Element("University").Value,
                               Semister = student.Element("Semister").Value
                           };
            var sortedStudents = from student in students orderby student.Age select student;
            foreach(var student in sortedStudents)
            {
                Console.WriteLine("student {0} with age {1} from University {2} is in his/her {3} semister", student.Name, student.Age, student.University, student.Semister);
            }
        }
    }
}
