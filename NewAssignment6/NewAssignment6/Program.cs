
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewAssignment6
{
    class Program
    {
        static void Main(string[] args)
        {
            Program menu = new Program();
            int choice = 0;
            do
            {
                DisplayMenu();
                Console.Write("Enter the number of your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 3:
                        {
                            Console.WriteLine("How many numbers whould you like to work with? ");
                            int nbr = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("The sum of the numbers is: {0}", +CalculateSum(nbr));
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("How many numbers whould you like to work with?");
                            int nbr = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("The sum of the squares of the numbers is: {0}", +CalculateSumOfSquares(nbr));
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("How many numbers whould you like to work with?");
                            int nbr = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("The sum of the cubes of the numbers is: {0}", +CalculateSumOfCubes(nbr));
                            break;
                        }
                    case 0:
                        {
                            continue;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid choice!! Try again.");
                            Console.WriteLine();
                            break;
                        }
                }
            }
            while (choice != 0);

            Console.ReadKey();
        }
        public static void DisplayMenu()
        {
            Console.WriteLine("Calculation Menu:");
            Console.WriteLine("3) Calculate Sum");
            Console.WriteLine("4) Calculate Sum of Squares");
            Console.WriteLine("5) Calculate Sum of Cubes");
            Console.WriteLine("6) Calculate the Average");
            Console.WriteLine("0) To Exit");
        }

        public static int CalculateSum(int nbr)
        {
            int[] sum_nbr = new int[nbr];

            for (int x = 1; x <= nbr; x++)//"nbr" is the number of integers for user to put for processing (calculating sum)
            {
                Console.Write("Enter a value: ");
                int y = Convert.ToInt32(Console.ReadLine());
                sum_nbr[x] = y;//calculate the sum of the numbers entered
            }
            int total_sum = sum_nbr.Sum();
            return total_sum;//return sum

        }

        public static int CalculateSumOfSquares(int nbr)
        {
            int[] sum_squares = new int[nbr];

            for (int x = 1; x <= nbr; x++)//"nbr" is the number of integers for user to put for processing (calculating sum of squares)
            {
                Console.Write("Enter a value: ");
                int y = Convert.ToInt32(Console.ReadLine());
                y = (int)Math.Pow(y, 2);//calculate the square of the number entered
                sum_squares[x] = y;
            }

            int total_squares = sum_squares.Sum();
            return total_squares;//return sum of the square
        }

        public static int CalculateSumOfCubes(int nbr)
        {
            int[] sum_cubes = new int[nbr];

            for (int x = 1; x <= nbr; x++)//"value" is the number of integers for user to put for processing (calculating sum of cubes)
            {
                Console.Write("Enter a value: ");
                int y = Convert.ToInt32(Console.ReadLine());
                y = (int)Math.Pow(y, 3);//calculate the cube of the number entered
                sum_cubes[x] = y;
            }

            int total_cubes = sum_cubes.Sum();
            return total_cubes;//return sum of the cube
        }

        public static double CalculateAverage(int nbr)
        {
            double avg = 0;

            for (int x = 1; x <= nbr; x++)//"value" is the number of integers for user to put for processing (calculating average)
            {
                Console.Write("Enter a value: ");
                double y = Convert.ToInt32(Console.ReadLine());
                avg = avg + y;//calculate the average of the numbers entered                
            }

            double average = avg / nbr;
            return average;//return the average
        }
    }
}
