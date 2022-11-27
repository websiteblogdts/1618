using System;
using System.Diagnostics.CodeAnalysis;

namespace FGWLap1Students
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name;
            int Age;
            double Grade;

            Console.WriteLine("Enter the name: ");
            Name = Console.ReadLine();// Nhap tu ban phim vao 1 chuoi
            Console.WriteLine("Enter the age: ");
            Age = int.Parse(Console.ReadLine());// Nhap tu ban phim vao 1 chuoi, nhung 
            Console.WriteLine("Enter the grade: ");
            Grade = double.Parse(Console.ReadLine());

            Console.WriteLine($"Hello, {Name} !, you look youger than your age {Age}");
            if (Grade >= 3)
            {
                Console.WriteLine($"You pass with the Grade:  {Grade}  ");
            }
            else
            {
                Console.WriteLine($"You not pass with the Grade: {Grade} ");
            }
        }
    }
}