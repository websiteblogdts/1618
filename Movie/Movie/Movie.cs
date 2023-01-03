using System.Collections.Generic;
using System.Linq;

namespace Movie
{
    internal class Movie
    {
        public string Title { get; set; }
        public string Language { get; set; }
        public string Genre { get; set; }
        public string Datetime { get; set; }
        public List<Ticket> Tickets { get; set; }

        public Movie()
        {
            Tickets = new List<Ticket>();
        }
        public Movie(int number, string title, string language, string genre, string datetime)
        {
            Title = title;
            Language = language;
            Genre = genre;
            Datetime = datetime;
            Tickets = new List<Ticket>();
        }
        public void BookingTicket(int number, string customerName, int slot, string movie, int hall)
        {
            var ticket = new Ticket(number, customerName, slot, movie, hall);
            Tickets.Add(ticket);
        }

        public Ticket SearchTicketByNumber(int number)
        {
            var result = Tickets.FirstOrDefault(x => x.Number == number);
            return result;
        }
        public bool DeleteTicketByNumber(int number)
        {
            var ticketFound = SearchTicketByNumber(number);
            if (ticketFound != null)
            {
                Tickets.Remove(ticketFound);
                return true;
            }
            return false;
        }



    }
}
