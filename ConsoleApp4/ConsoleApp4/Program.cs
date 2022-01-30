using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {//identifier
            double ad_ticket, ch_ticket, nbrTickets;
            ad_ticket = 3.75;
            ch_ticket = 2.75;

            string nbrAdult, nbrChild;

            //input
            Console.WriteLine("Insert the number of adults ticket: ");
            nbrAdult = Console.ReadLine();

            Console.WriteLine("Insert the number of child ticket: ");
            nbrChild = Console.ReadLine();

            //processing
            double sumAdult = Convert.ToDouble(nbrAdult) * ad_ticket;
            double sumChild = Convert.ToDouble(nbrChild) * ch_ticket;
            double totalValue = sumAdult + sumChild;
            nbrTickets = Convert.ToDouble(nbrAdult) + Convert.ToDouble(nbrChild);

            //output
            Console.WriteLine($"Total of tickets: {nbrTickets}");
            Console.WriteLine($"Coast total: $ {totalValue:C2}");
            Console.ReadKey();
        }
    }
}
