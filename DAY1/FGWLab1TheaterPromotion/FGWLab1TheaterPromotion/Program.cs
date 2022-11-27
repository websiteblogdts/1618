namespace FGWLab1TheaterPromotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfDay;
            int age, ticketSale = 0;
            Console.WriteLine("Enter type of the day: ");
            typeOfDay = Console.ReadLine();
            Console.WriteLine("Enter your age: ");
            age = int.Parse(Console.ReadLine());

            switch (typeOfDay)
            {
                case "Weekday":
                    if (age >= 0 && age <= 18)
                    {
                        ticketSale = 12;
                    }
                    else if (age <= 64)
                    {
                        ticketSale = 18;
                    }
                    else if (age <= 122)
                    {
                        ticketSale = 12;
                    }
                    else
                    { Console.WriteLine("Error age"); }
                    break;
                case "Weekend":
                    if (age >= 0 && age <= 18)
                    {
                        ticketSale = 15;
                    }
                    else if (age <= 64)
                    {
                        ticketSale = 20;
                    }
                    else if (age <= 122)
                    {
                        ticketSale = 15;
                    }
                    else
                    { Console.WriteLine("Error age"); }
                    break;
                case "Hoiday":
                    if (age >= 0 && age <= 18)
                    {
                        ticketSale = 5;
                    }
                    else if (age <= 64)
                    {
                        ticketSale = 12;
                    }
                    else if (age <= 122)
                    {
                        ticketSale = 10;
                    }
                    else
                    { Console.WriteLine("Error age"); }
                    break;
                default:
                    Console.WriteLine("Invalid type of day");
                    break;

            }
            Console.WriteLine($"Confirm the ticket price: {ticketSale} with the {typeOfDay} and age {age}");
        }
    }
}