using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)//main method
        {
            //Write a program that prompts the user for his name, annual salary,
            //and monthly expenses.The program will display the user's name, MONTHLY salary, and monthly
            // expenses and extra money(see the sample blow)
            //below how to calculate the monthly salary and extra money:
            //the monthly salary = annual salary / 12
            //the extra money = income - expenses
            //Use the "c" is your format specifier to display a number as a currency
            Console.Write("Enter the width: ");
            double width = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the height: ");
            double height = Convert.ToDouble(Console.ReadLine());

            float area ;

            area = (float)(width * height);

            Console.WriteLine($"The area is: {area:F}");
            Console.ReadKey();

        }
    }
}
