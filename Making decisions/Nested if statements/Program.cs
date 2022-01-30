using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_if_statements
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = 10, second = 12;
            if(first == second)
            { 
                Console.WriteLine("These two numbers are equal.");
            }
            else
            {
                if (first > second)
                {
                    Console.WriteLine("The first number is bigger.");
                }
                else
                {
                    Console.WriteLine("The second is bigger.");
                }
            }
            Console.ReadKey();
        }
    }
}
