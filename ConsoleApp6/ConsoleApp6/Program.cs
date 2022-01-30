using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise do-while vs. while statements


            /*Console.WriteLine("please enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int factorial = 1;
            do
            {
                factorial *= n;
                n--;
            }
            while (n > 0);
            {
                Console.WriteLine($"n! = {+ factorial}");
            }
                Console.ReadKey();*/

            Console.WriteLine("please enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int factorial = 1;
            while (n > 1)
            {
                factorial *= n;
                n--;
            }
            
                Console.WriteLine($"n! = {+factorial}");
            
            Console.ReadKey();
        }
    }
}
