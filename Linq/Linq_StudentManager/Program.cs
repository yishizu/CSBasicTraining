using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq_StudentManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            UniversityManager um = new UniversityManager();
            um.MaleStudents();
            Console.ForegroundColor = ConsoleColor.Blue;
            um.FemaleStudents();
            Console.ForegroundColor = ConsoleColor.Red;
            um.SortStudentByAge();
            um.StudentAndUniversityNameCollocetion();

            /*
            int[] someInt = { 30, 12, 4, 3, 12 };
            IEnumerable<int> sortedInts = from i in someInt orderby i select i;
            IEnumerable<int> reversedInts = sortedInts.Reverse();
            IEnumerable<int> reversedSortedInts = from i in someInt orderby i descending select i;
            foreach(int i in reversedSortedInts)
            {
                Console.WriteLine(i);
            }
            
            string input = Console.ReadLine();
            try
            {

                int inputAsInt = Convert.ToInt32(input);
                um.AllStudentsFromThatUni(inputAsInt);
            }catch(Exception e)
            {
                Console.WriteLine(e.Message ); 
            }
            Console.Read();*/
        }
    }
}
