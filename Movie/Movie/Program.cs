using System;

namespace Movie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MenuOption();
            Movie movie1 = new Movie(1, "TOM AND TOM", "ENGLISH", "FUNNY", "JANUARY 1ST");
            Movie movie2 = new Movie(2, "TOY STORY", "VIETNAMESE", "ROMATIC", "FEBRUARY 2ND");
            

            Cinema cinema = new Cinema();
            cinema.Hall1.Add(movie1);q
            cinema.Hall1.Add(movie2);
            cinema.Hall2.Add(movie1);
            Movie movie = new Movie();
            cinema.Movies.Add(movie1);
            cinema.Movies.Add(movie2);  
            
            while (true)
            {
                Console.WriteLine("ENTER YOUR CHOICE(1-9): ");
                int userchoice = int.Parse(Console.ReadLine());
                if (userchoice>9||userchoice<1)
                {
                    Console.WriteLine("PLEASE ENTER VALID NUMBER!");
                    continue;
                }
                switch (userchoice)
                {
                    case 1:
                        Console.WriteLine("THERE ARE SOME MOVIES: ");
                        foreach (var movies in cinema.Movies)
                        {
                            cinema.DisplayMovie(movies);
                        }
                        break;

                    case 2:
                        Console.WriteLine("PLEASE ENTER NAME OF MOVIE:");
                        string searchName = Console.ReadLine();
                        searchName = searchName.ToUpper();
                        var moviesFound = cinema.SearchMovieByName(searchName);
                        cinema.DisplayMovies(moviesFound);
                        break;
                    case 3:
                        Console.Write("PLEASE ENTER GENRE OF MOVIE:");
                        string searchGenre = Console.ReadLine();
                        searchGenre = searchGenre.ToUpper();
                        var genreFounded = cinema.SearchMovieByGenre(searchGenre);
                        cinema.DisplayMovies(genreFounded);
                        break;
                    case 4:
                        Console.Write("PLEASE ENTER DATE OF MOVIE:");
                        string searchDate = Console.ReadLine();
                        searchDate = searchDate.ToUpper();
                        var dateFounded = cinema.SearchMovieByDate(searchDate);
                        cinema.DisplayMovies(dateFounded);
                        break;
                    case 5:
                        Console.WriteLine("ENTER HALL NUMBER(1-2): ");
                        int hallNumber = int.Parse(Console.ReadLine());
                        if (hallNumber==1)
                        {
                            foreach (var item in cinema.Hall1)
                            {
                                cinema.DisplayMovie(item);
                            }
                            Console.Write("ENTER THE NAME OF MOVIE:");
                            string movieChoice1 = Console.ReadLine().ToUpper();
                            Movie movieFound = cinema.SearchMovieInHall1(movieChoice1);
                            if (movieFound!=null)
                            {
                                if (movieChoice1 == movie1.Title)
                                {
                                    Console.WriteLine("WE HAVE IT ON "+movie1.Datetime);
                                    cinema.DisplayMovie(movie1);
                                    int number = movie.Tickets.Count+1;
                                    Console.WriteLine("TICKET NUMBER: "+number);
                                    Console.Write("ENTER YOUR NAME:");
                                    string customer = Console.ReadLine().ToUpper();
                                    Console.Write("ENTER YOUR SLOT:");
                                    int slot = int.Parse(Console.ReadLine());
                                    movie.BookingTicket(number, customer, slot, movie1.Title, hallNumber);
                                    Console.WriteLine("TICKET BOOKED SUCCESSFULLY!");
                                    Console.WriteLine("THIS IS YOUR TICKET:");
                                    foreach (var itemTicket in movie.Tickets)
                                    {
                                        itemTicket.DisplayDetails();
                                    }
                                }
                                else if (movieChoice1 == movie2.Title)
                                {
                                    Console.WriteLine("WE HAVE IT ON "+movie2.Datetime);
                                    cinema.DisplayMovie(movie2);
                                    int number = movie.Tickets.Count+1;
                                    Console.WriteLine("TICKET NUMBER: "+number);
                                    Console.Write("ENTER YOUR NAME:");
                                    string customer = Console.ReadLine().ToUpper();
                                    Console.Write("ENTER YOUR SLOT:");
                                    int slot = int.Parse(Console.ReadLine());
                                    movie.BookingTicket(number, customer, slot, movie2.Title, hallNumber);
                                    Console.WriteLine("TICKET BOOKED SUCCESSFULLY!");
                                    Console.WriteLine("THIS IS YOUR TICKET:");
                                    foreach (var itemTicket in movie.Tickets)
                                    {
                                        itemTicket.DisplayDetails();
                                    }
                                }


                            }
                            else
                            {
                                Console.WriteLine("THIS HALL DOES NOT CONTAIN THIS MOVIE!!!");
                                break;
                            }
                        }
                        else if (hallNumber==2)
                        {
                            foreach (var item in cinema.Hall2)
                            {
                                cinema.DisplayMovie(item);
                            }
                            Console.Write("ENTER THE NAME OF MOVIE:");
                            string movieChoice2 = Console.ReadLine().ToUpper();
                            Movie movieFound = cinema.SearchMovieInHall2(movieChoice2);
                            if (movieFound != null)
                            {
                                if (movieChoice2==movie1.Title)
                                {
                                    Console.WriteLine("WE HAVE IT ON "+movie1.Datetime);
                                    cinema.DisplayMovie(movie1);
                                    int number = movie.Tickets.Count+1;
                                    Console.WriteLine("TICKET NUMBER: "+number);
                                    Console.Write("ENTER YOUR NAME:");
                                    string customer = Console.ReadLine().ToUpper();
                                    Console.Write("ENTER YOUR SLOT:");
                                    int slot = int.Parse(Console.ReadLine());
                                    movie.BookingTicket(number, customer, slot, movie1.Title, hallNumber);
                                    Console.WriteLine("TICKET BOOKED SUCCESSFULLY!");
                                    Console.WriteLine("THIS IS YOUR TICKET:");
                                    foreach (var itemTicket in movie.Tickets)
                                    {
                                        itemTicket.DisplayDetails();
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("THIS HALL DOES NOT CONTAIN THIS MOVIE!!!");
                            }

                        }
                        else
                        {
                            Console.WriteLine("HALL NOT FOUND! ");
                            break;
                        }
                        break;
                    case 6:
                        if (movie.Tickets.Count == 0)
                        {
                            Console.WriteLine("NO RESULT");
                            break;
                        }
                        Console.WriteLine("YOUR TICKET:");
                        foreach (var tickets in movie.Tickets)
                        {
                            tickets.DisplayDetails();
                        }

                        break;
                    case 7:
                        if (movie.Tickets.Count == 0)
                        {
                            Console.WriteLine("NO TICKET YET!");
                            break;
                        }
                        Console.WriteLine("ENTER TICKET NUMBER");
                        int deletedTicketNumber = int.Parse(Console.ReadLine());
                        var isDeleted = movie.DeleteTicketByNumber(deletedTicketNumber);
                        if (isDeleted)
                        {
                            Console.WriteLine("DELETE SUCCESSFULLY ...");
                        }
                        else
                        {
                            Console.WriteLine("TICKET NOT FOUND ...");
                        }
                        Console.WriteLine("YOUR TICKET NOW:");
                        foreach (var ticketNow in movie.Tickets)
                        {
                            ticketNow.DisplayDetails();
                        }
                        break;
                    case 8:
                        if (movie.Tickets.Count == 0)
                        {
                            Console.WriteLine("NO TICKET YET!");
                            break;
                        }
                        Console.WriteLine("ENTER TICKET NUMBER");
                        int updatedTicketNumber = int.Parse(Console.ReadLine());
                        Ticket updateTicket = movie.SearchTicketByNumber(updatedTicketNumber);
                        if (updateTicket == null)
                        {
                            Console.WriteLine("NO RESULT!!");
                        }
                        else
                        {
                            Console.Write("ENTER NEW CUSTOMER NAME: ");
                            string newCustomerName = Console.ReadLine().ToUpper();
                            Console.Write("ENTER NEW SLOT: ");
                            int newSlot = int.Parse(Console.ReadLine());
                            updateTicket.CustomerName = newCustomerName;
                            updateTicket.Slot = newSlot;
                            Console.WriteLine("SUCCESSFULLY UPDATE!");
                        }
                        break;
                    case 9:
                        Console.WriteLine("GOOD BYE!");
                        return;
                }
                MenuOption();
            }
        }
        public static void MenuOption()
        {
            Console.WriteLine("+++++TIKET BOOKING APLICATION+++++");
            Console.WriteLine("1. VIEW ALL MOVIES");
            Console.WriteLine("2. SEARCH MOVIE BY NAME");
            Console.WriteLine("3. SEARCH MOVIE BY GENRE");
            Console.WriteLine("4. SEARCH MOVIE BY TIME");
            Console.WriteLine("5. CREATE YOUR TICKET");
            Console.WriteLine("6. LIST YOUR TICKETS");
            Console.WriteLine("7. CANCEL YOUR TICKET");
            Console.WriteLine("8. UPDATE YOUR TICKET");
            Console.WriteLine("9. EXIT");
            Console.WriteLine("PLEASE ENTER YOUR CHOICE!!!");
        }
    }
}