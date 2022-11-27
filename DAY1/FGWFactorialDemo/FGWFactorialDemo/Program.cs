using System;

namespace FGWFactorialDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            int fact = 1, number;
            Console.WriteLine("Factorial Application");

            Console.WriteLine("Enter the number: ");
            number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("Factorial of " + number + " is = " + fact);
        }
    }
}
