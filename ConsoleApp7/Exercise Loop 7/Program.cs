using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Loop_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //7. To repeatedly prompt for a number and sum it. When the sum just exceeds 100,
            //stop the prompting and display the sum at the end. You must not display the sum
            //while the user in typing in numbers. (You do not need a counter but you will need
            //some way of terminating the loop)
            int sum = 0;
            bool toContinue = true;

            for (int number = 1; ; number++)
            {
                do
                {
                    if (sum < 100)
                    {
                        sum = sum + number;
                        Console.Write($"{number} ");
                        Console.WriteLine($"sum = {sum}");
                        number++;
                    }
                    else
                        toContinue = false;
                }
                while (toContinue);
                Console.ReadKey();
            }
            
        }
        
    }
}
