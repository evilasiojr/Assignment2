using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exercise_Loop_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //To display the numbers 1 ... 5 on separate lines
            /*int number = 1;
            
            do
            {
                Console.WriteLine($"{number}");
                number++;
            }
            while (number < 6);
            Console.ReadKey();*/

            for (int number = 1; number <= 5; number++)
            {
                Console.WriteLine($"{number}");
            }
            Console.ReadKey();
        }
    }
}
