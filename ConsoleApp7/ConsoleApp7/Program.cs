using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Random random = new Random();
            int number = random.Next(0, 101);
            
            Console.WriteLine("Guess the number: ");
            int guess = Convert.ToInt32(Console.ReadLine());
            while (guess != number)
            {
                if (guess < number)
                    Console.WriteLine("Too low!");
                else
                    Console.WriteLine("Too high!");

                Console.WriteLine("Enter your guess: ");
                guess = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Yes, You got it!");
            */
            //1. To display five asterisks on a single line. Each asterisk must be separated
            //by a space. You must use a do-while loop to solve this program

            char a = '*';
            int count = 0;
            do
            {
                Console.Write($"{a} ");
                count++;
            }
            while (count < 5);

            Console.ReadLine();
            
            /*for (int a = 1; a <= 5; a++)
            {
                Console.Write("* ");
            }
            Console.ReadKey();*/
        }
    }
}
