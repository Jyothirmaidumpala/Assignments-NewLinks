using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement3
{
    class TicketException : ApplicationException
    {
        public TicketException(string msg) : base(msg)
        {

        }
    }
    class Ticket
    {
        string name;
        int age;
        int ticket;
        public void TicketBooking()
        {
            Console.WriteLine("ENter the name of the person:");
            name = Console.ReadLine();

            Console.WriteLine("ENter the age of the person:");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ENter no of Tickets to be booked:");
            if (ticket > 2)
            {
                throw (new TicketException("Cannot book more than 2 tickets."));
            }
            else
            {
                Console.WriteLine("Ticket Booked Successfully");
            }

        }
    }
    class Ticketprj
    {
        static void Main(string[] args)
        {
            Ticket t = new Ticket();
            try
            {
                t.TicketBooking();
            }
            catch (TicketException te)
            {
                Console.WriteLine(te.Message + " " + te.Source);
            }
            Console.ReadLine();
        }
    }
}


