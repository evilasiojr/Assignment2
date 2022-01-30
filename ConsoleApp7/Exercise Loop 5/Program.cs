using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Loop_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //5. To display the numbers 10... 40 on separate lines with an asterisk before each
            //multiple of 7. (asterisk multiples)
            /*double number = 10;

            do
            {
                if (number % 7 != 0)
                {
                    Console.WriteLine($"{number}");
                }
                else
                    Console.WriteLine($"*{number}");
                number++;
            }
            while (number < 40);
            Console.ReadKey();*/

            for (int number = 10; number < 40; number++)
            {
                if (number %7 != 0)
                {
                    Console.WriteLine($"{number}");
                }
                else
                {
                    Console.WriteLine($"*{number}");
                }
            }
            Console.ReadKey();
        }
    }
}
