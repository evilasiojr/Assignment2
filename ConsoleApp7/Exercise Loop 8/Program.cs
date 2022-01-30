using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Loop_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //7. To repeatedly prompt for a number and sum it. When the sum just exceeds 100,
            //stop the prompting and display the sum at the end. You must not display the sum
            //while the user in typing in numbers. (You do not need a counter but you will need
            //some way of terminating the loop)

            //8. Same as the previous question but additionally displays the average of the
            //numbers when the loop terminates. You will need a counter but not as a loop
            //terminator.
            double average;
            bool toContinue = true;
            int sum = 0;

            for (int number = 1; ;)
            {
                do
                {
                    if (sum < 100)
                    {
                        Console.Write($"{number} ");
                        sum = sum + number;
                        Console.WriteLine($"sum {sum}");
                        number++;
                    }
                    else
                        toContinue = false;
                }
                while (sum < 100);

                average = sum / number;
                Console.WriteLine($"Average = {average:F}");
                Console.ReadKey();
            }
            

        }
    }
}
