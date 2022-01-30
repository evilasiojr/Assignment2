using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Loop_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //4. To display the numbers 1 ... 20 on separate lines with an asterisk after
            //each multiple of 5. (multiples asterisk)
            /*int number = 1;
            do
            {
                if (number %5 != 0)
                {
                    Console.WriteLine($"{number}");
                }
                else
                    Console.WriteLine($"{number}*");
                number++;
            }
            while (number < 21);
            Console.ReadKey();*/
            for (int number = 1; number <= 20; number++)
            {
                if (number % 5 != 0)
                {
                    Console.WriteLine($"{number}");
                }
                else
                {
                    Console.WriteLine($"{number}*");
                }
               
            }
            Console.ReadKey();
        }
    }
}
