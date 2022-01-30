using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q12
{
    class Program
    {
        static void Main(string[] args)
        {
            int feeSplit;
            double length, width, area, small, medium, large;

            small = 25.00;
            medium = 35.00;
            large = 50.00;
            feeSplit = 3 * 20;

            Console.WriteLine("Enter the length of the lawn: ");
            length = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the width of the lawn: ");
            width = Convert.ToDouble(Console.ReadLine());

            area = length * width;

            if (area < 400)
            {
                Console.WriteLine($"Weekly mowing fee = ${small}");
                Console.WriteLine($"Fee for the season (20 weeks) = ${small * 20}");
            }
            else if (area >= 400 && area < 600)
            {
                Console.WriteLine($"Weekly mowing fee = ${medium}");
                Console.WriteLine($"Fee for the season (20 weeks) = ${medium * 20}");
            }
            else if (area >= 600)
            {
                Console.WriteLine($"Weekly mowing fee = ${large}");
                Console.WriteLine($"Fee for the season (20 weeks) = ${large * 20}");
            }
            Console.ReadKey();

        }
    }
}
