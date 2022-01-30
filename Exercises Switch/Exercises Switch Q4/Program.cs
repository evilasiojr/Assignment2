using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_Switch_Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that prompts the user for the number of courses and residency status
            //(domestic or international) and calculates tuition cost. Cost is calculated based on the table below.
            //Domestic          $325 per course
            //International     $1375 per course
            //You decide how you want the user to enter her/his residency status and prompt accordingly, also
            //you should use named constants for the cost per course.

            Console.WriteLine("What is your residence status? [1 - Domestic / 2 - International]");
            int residence = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many courses will you study?");
            int course = Convert.ToInt32(Console.ReadLine());

            int total_dom = 325 * course;
            int total_int = 1375 * course;

            switch (residence)
                {
                    case '1': Console.WriteLine($"Your tuition will be {total_dom}."); break;
                    case '2': Console.WriteLine($"Your tuition will be {total_int}."); break;
                    default: Console.WriteLine("Invalid option. Try again."); break;
                }

            Console.ReadKey();
        }
    }
}
