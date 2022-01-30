using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week05_Q6
{
    class Program
    {
        static void Main(string[] args)
        {
            int score;
            double sum = 0;

            for (int player = 1; player <= 5; player++)
            {
                
                for (int game = 1; game <= 3; game++)
                {
                    Console.Write($"{player} Bowler, game {game}: ");
                    score = Convert.ToInt32(Console.ReadLine());
                    sum = sum + score;

                }
                
            }
            double avg = sum / 15.0;
            Console.WriteLine($"The average of team is: {avg:F}");

            Console.ReadKey();
        }
    }
}
