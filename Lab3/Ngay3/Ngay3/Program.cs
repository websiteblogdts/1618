using System;

namespace Ngay3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] days = { "Thu 2", "Thu 3", "Thu 4", "Thu 5", "Thu 6", "Thu 7", "Chu Nhat" };
            int day;
            Console.WriteLine("Nhap So tu ngay tu 1 - 7 !");
            day = int.Parse(Console.ReadLine());
            if (day >= 1 && day <= 7)
            {
                Console.WriteLine(days[day - 1]);

            }
            else
            {
                Console.WriteLine("Invalid Day");
            }
        }
    }

}