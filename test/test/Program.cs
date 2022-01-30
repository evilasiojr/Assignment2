using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            double rate1 = 5.65;
            double rate2 = 49.99;

            Console.WriteLine("Please enter hourly payrate");

            double rate = Convert.ToDouble(Console.ReadLine());

            if (rate < rate1 || rate > rate2) 
                {
                Console.WriteLine("Invalid rate. Please enter the correct rate");

                rate = Convert.ToDouble(Console.ReadLine());
                if (rate < rate1 || rate > rate2)
                {
                    Console.WriteLine("Invalid rate. Please enter the correct rate");

                }
                else
                    Console.WriteLine($"Disply rate per hour {rate * 40:C}");

            }
            else
                Console.WriteLine($"Disply rate per hour {rate * 40:C}");


            Console.ReadKey();

        }
    }
    
}
