using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5_datetimeobject
{
     class MyDatetime
    {
        public int Day { get; set; }
        public int Month { get; set; }  
        public int Year { get; set; }

        public MyDatetime() 
        {
          
        }

        public MyDatetime(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        public void displayTheDate()
        {
            Console.WriteLine($"DateTime is { Day } and { Month } and { Year }");
        }

        public void calAndPrintTheDayOfWeek()
        {
            Console.WriteLine("Enter the date d - M - yyyy");
            string dateAsText = Console.ReadLine();
            DateTime currentDateTime = DateTime.ParseExact(dateAsText, "d-M-yyyy",CultureInfo.InvariantCulture);
            Console.WriteLine(currentDateTime.DayOfWeek);
        }
    }

}
