using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_Switch_Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Write a program that prompts the user for a menu choice. The program will display a message based
            //on the following table:
            //Choice                Message
            //1                     "Calculate area"
            //2                     "Calculate volume"
            //3                     "Calculate surface area"
            //0                     "Exit the program"
            //<< any other input>>  "ERROR: Invalid choice
            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            switch (number)
            {
                case 0: Console.WriteLine("Exit the program"); break;
                case 1: Console.WriteLine("Calculate area"); break;
                case 2: Console.WriteLine("Calculate volume"); break;
                case 3: Console.WriteLine("Calculate surface area"); break;
                default: Console.WriteLine("ERROR: Invalid choice"); break;
            }
            Console.ReadKey();
        }
    }
}
