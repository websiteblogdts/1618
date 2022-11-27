using System;

namespace lab2_SumOfRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Count Number: ");
            int count = int.Parse(Console.ReadLine());
            decimal sum = 0;

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Enter Number: ");
                decimal number = decimal.Parse(Console.ReadLine());
                sum += number;
            }

            Console.WriteLine(sum);
        }
    }
}
