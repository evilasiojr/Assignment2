using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Loop_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //6. To display numbers 20 ... 60 on separate lines skipping the multiple of 3.
            //i.e. You must print a blank line for each multiple
            /*int number = 20;
            do
            {
                if (number % 3 != 0)
                {
                    Console.WriteLine($"{number}");
                }
                else
                    Console.WriteLine();
                number++;
            }
            while (number < 60);
            Console.ReadKey();*/

            for(int number = 20; number <= 60; number++)
            {
                if (number % 3 != 0)
                {
                    Console.WriteLine($"{number}");
                }
                else
                    Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
