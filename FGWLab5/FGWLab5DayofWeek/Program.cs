using System;

namespace FGWLab5DateTimeObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("create the birthday!");
            MyDateTime myDateTime = new MyDateTime(2, 3, 2000);
            myDateTime.displayTheData();

            MyDateTime myDateTime1 = new MyDateTime();
            myDateTime1.calAndPrintTheDayOfWeek();
        }
    }
}