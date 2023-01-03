using System;

namespace lab5_datetimeobject
{
    internal class Program
    {
        static void Main(string[] args)
        {

           /* Console.WriteLine("create the birthday!");
            MyDatetime myDateTime = new MyDatetime(2, 3, 2000);
            myDateTime.displayTheDate();*/

            MyDatetime myDatetime1 = new MyDatetime();
            myDatetime1.calAndPrintTheDayOfWeek();
            
        }
    }
}