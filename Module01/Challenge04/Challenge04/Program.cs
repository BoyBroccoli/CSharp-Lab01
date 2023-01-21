using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge04
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstPosition = 0;
            int secondPosition = 1;

            Console.WriteLine("How many students will you like to enter?");

            int studentCount = int.Parse(Console.ReadLine());

            // creating 2d array

            var studentsAndGrades = new string[studentCount, 2];

            for(int i=0; i < studentCount; i++)
            {
                Console.WriteLine("Please Enter The Student Name: ");
                studentsAndGrades[i,firstPosition] = Console.ReadLine();

                Console.WriteLine("Please Enther The Student Grade: ");
                studentsAndGrades[i, secondPosition] = Console.ReadLine();
            }

            for(int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"Name: {studentsAndGrades[i, firstPosition]}, Grade: {studentsAndGrades[i, secondPosition]}");
            }
        }
    }
}
