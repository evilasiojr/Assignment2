using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            string nbr;

            Console.WriteLine("Insert any number: ");
            nbr = Console.ReadLine();
            number = (int)Convert.ToDouble(nbr);

            //processing
            double d_number = Convert.ToDouble(nbr);
            int i_number = Convert.ToInt32(number);
            char c_number = Convert.ToChar(i_number);

            //output
            Console.WriteLine($"The input as a double: {d_number}");
            Console.WriteLine($"The input as an int: {i_number}");
            Console.WriteLine($"The input as a char: {c_number}");

            Console.ReadKey();
        }
    }
}
