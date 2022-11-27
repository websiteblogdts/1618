using System;

namespace FGWLap130min
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            string currentTime;
            int minutesToAdd, currentHour, currentMinutes, futureMinutes, futureHour;
            string[] totalTime;
            Console.WriteLine("enter the current int HH:MM Format: ");
            currentTime = Console.ReadLine();
            Console.WriteLine("enter the amount of minutes you want to add: ");
            minutesToAdd = int.Parse(Console.ReadLine());
            totalTime = currentTime.Split(':');

            currentHour = int.Parse(totalTime[0]);
            currentMinutes = int.Parse(totalTime[1]);

            futureMinutes = (currentMinutes + minutesToAdd) % 60;

            futureHour = (currentHour + (currentMinutes + minutesToAdd) / 60) % 24;

            Console.WriteLine("New Time: {0}:{1}", futureHour.ToString("D2"), futureMinutes.ToString("D2"));

        }
    }
}