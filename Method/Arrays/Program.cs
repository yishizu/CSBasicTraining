using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] grades = new int[5];

            grades[0] = 20;
            grades[1] = 23;
            grades[2] = 12;
            grades[3] = 9;
            grades[4] = 12;

            Console.WriteLine("grades at index 0 : {0}", grades[0]);

            string input = Console.ReadLine();
            grades[0] = int.Parse(input);

            Console.WriteLine("grades at index 0 : {0}", grades[0]);


            int[] gradeOfMathStudentA = { 20, 23, 23, 12, 23, 42 };

            int[] gradeOfMathStudentB = new int[] { 9, 3, 12, 32, 4 };

            Console.WriteLine("Length of gradeOfMathStudentA: {0}",gradeOfMathStudentA.Length);

            //foreadch

            int[] nums = new int[10];

            for (int i = 0; i < 10; i++){
                nums[i] = i*2;
            }

            int counter = 0;
            foreach (int num in nums)
            {
                Console.WriteLine(num +" " + counter);
                counter++;
            }

            //declare 2D array
            string[,] matrix;

            //3D
            int[,,] threeD;

            //two dimensional array
            int[,] array2D = new int[,]
            {
                {1,2,3 }, // row1
                {4,5,6 }, // row2
                { 7,8,9} // roww3
            };
            Console.WriteLine("Central value is {0}", array2D[1,1]);

            string[,,] array3D = new string[,,]
            {
                {
                    {"000","001" },
                    {"010","011" }
                },
                {
                    {"100","001" },
                    {"110","011" }
                }
            };
            
        }

    }
}
