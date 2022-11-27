using System;

namespace lab2_CircleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Radius: ");
            double r = double.Parse(Console.ReadLine());
            double area = Math.PI * r * r;
            Console.WriteLine("{0:F12}", area);
        }
    }
}
