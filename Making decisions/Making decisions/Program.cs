using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Making_decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number.");
            string s = Console.ReadLine();
            int number = int.Parse(s);
            if (number %2 == 0)
            {
                Console.WriteLine("This number is even.");
            }
            else
            {
                Console.WriteLine("This number is odd.");
            }
            Console.ReadKey();
        }
    }
}
