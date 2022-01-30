using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Assigment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double number;
            string nbr;

            Console.WriteLine("Insert any number: ");
            nbr = Console.ReadLine();
            number = (int)Convert.ToDouble(nbr);

            //processing
            int i_number = Convert.ToInt32(number);
            char c_number = Convert.ToChar(i_number);

            //output
            Console.WriteLine($"The input as a double: {number}");
            Console.WriteLine($"The input as an int: {i_number}");
            Console.WriteLine($"The input as a char: {c_number}");
            Console.ReadKey();
        }
    }
}
