using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyTickets
{
    public class HappyTicketVerification
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter your ticket number");
            var ticketNumber = Console.ReadLine();
            string part1 = ticketNumber.Substring(0, 3);
            string part2 = ticketNumber.Substring(3, 3);
            int firstPart = Convert.ToInt32(part1);
            int secondPart = Convert.ToInt32(part2);

            int sumFirst = 0;
            while (firstPart != 0)
            {
                sumFirst += firstPart % 10;
                firstPart /= 10;
            }

            int sumSecond = 0;
            while (secondPart != 0)
            {
                sumSecond += secondPart % 10;
                secondPart /= 10;
            }

            if (sumFirst == sumSecond)
            {
                Console.WriteLine("Congrats!You have a happy ticket :)");
            }
            else
            {
                Console.WriteLine("Sorry, ticket isn't happy.");
            }


        }
    }
}
