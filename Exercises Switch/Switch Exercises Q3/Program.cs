using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Exercises_Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. Write a program that allows the user to enter two integers and a character If the character is A,
            //add the two integers If it is S, subtract the second integer from the first else multiply the
            //integers Display the results of the arithmet
            
            Console.WriteLine("Enter the first integer: ");
            int st = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second integer: ");
            int nd = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a character [A/S]: ");
            char ch = Convert.ToChar(Console.ReadLine());
            
            int sum, sub, mult;

            sum = st + nd;
            sub = st - nd;
            mult = st * nd;

            if (ch != 'A' && ch != 'S')
            {
                Console.WriteLine($"{st} * {nd} = {mult}");
            }
            else
            {
                if (ch == 'A')
                    Console.WriteLine($"{st} + {nd} = {sum}.");

                else
                {
                    Console.WriteLine($"{st} - {nd} = {sub}.");
                }
            }
        
            Console.ReadKey();

        }
    }
}
