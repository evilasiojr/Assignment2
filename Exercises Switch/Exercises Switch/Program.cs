using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Write a c# program that prompts the user for a single letter. If the letter is a then display Apple,
            //if the letter is b or c then display Baby or Candy or anything else Sorry I don’t know that letter

            Console.Write("Enter a letter: ");
            char letter = Convert.ToChar(Console.ReadLine());

            switch (letter)
            {
                case 'A':
                    Console.WriteLine("Apple"); break;
                case 'B':
                case 'C':
                    Console.WriteLine("Baby or Candy"); break;
                default:
                    Console.WriteLine("Sorry I don't know that letter"); break;
            }
            Console.ReadKey();
        }
    }
}
