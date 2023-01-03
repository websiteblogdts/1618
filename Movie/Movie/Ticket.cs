using System;


namespace Movie
{
    internal class Ticket
    {
        public int Number { get; set; }
        public string CustomerName { get; set; }
        public int Slot { get; set; }
        public int Price { get; set; }
        public string MovieChoice { get; set; }
        public int Hall { get; set; }

        public Ticket(int number, string customerName, int slot, string movie, int hall)
        {
            Number = number;
            CustomerName = customerName;
            Slot = slot;
            Price = 100;
            MovieChoice = movie;
            Hall = hall;
        }

        public Ticket()
        {

        }
        public void DisplayDetails()
        {
            Console.WriteLine("Number: "+Number);
            Console.WriteLine("Movie: "+MovieChoice);
            Console.WriteLine("Customer's Name: "+CustomerName);
            Console.WriteLine("Slot: "+Slot);
            Console.WriteLine("Hall: Hall "+Hall);
            Console.WriteLine("Price: "+Price);
        }



    }
}
