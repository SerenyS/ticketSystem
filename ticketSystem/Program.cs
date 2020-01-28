using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ticketSystem
{
    static class Tickets
    {
        public static void Main(string[] args)
        {
            string file = "tickets.csv";
            string selection;

            Console.WriteLine("1.Enter new ticket");
            Console.WriteLine("2.Read current tickets");
            Console.WriteLine("3.Exit Program");

            selection = Console.ReadLine();

            if (selection == "1")
            {
                string TicketId;
                string Summary;
                string Status;
                string Prioty;
                string Submitter;
                string Assigned;
                string Watching;

         
                Console.WriteLine("What is the Ticket Id?");
                TicketId = Console.ReadLine();

                Console.WriteLine("What is this ticket for?");
                Summary = Console.ReadLine();


              
            }
            else if (selection == "2")
            {

            }
          else {

            }
        }

    }
}
