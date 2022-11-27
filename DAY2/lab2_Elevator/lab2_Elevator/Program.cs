using System;
namespace lab2_Elevator
{
    class Elevator
    {
        static void Main(string[] args)
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            int countOfCourses = (int)Math.Ceiling((double)countOfPeople / capacity);
            Console.WriteLine(countOfCourses);
        }
    }
}