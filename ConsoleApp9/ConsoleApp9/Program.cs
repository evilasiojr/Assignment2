using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        public static double CalculateAverage()
        {
            Console.Write("Enter the inputs:  ");
            int num = Convert.ToInt32(Console.ReadLine());
            double total = 0;
            int number = 0;
            for (int i = 1; i <= num; i++)
            {
                Console.Write("Enter number:  ");
                double num1 = Convert.ToDouble(Console.ReadLine());
                number++;
                total += num1;
            }
            double average = total / number;
            return average;
        }

        static void Main(string[] args)
        {
            DisplayMenu();


            Console.ReadKey();
        }
    }
}
