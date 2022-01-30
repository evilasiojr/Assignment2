using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Loop_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //To display the numbers 1... 20 on separate lines

            /*int number = 1;

            do
            {
                Console.WriteLine($"{number}");
                number++;
            }
            while (number < 21);
            Console.ReadKey();*/
            for (int number = 1; number <=20; number++)
            {
                Console.WriteLine($"{number}");
            }
            Console.ReadKey();

        }
    }
}
