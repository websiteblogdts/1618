using System;
namespace FGWLab1MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int theInteger, product = 0;
            do
            {
                Console.WriteLine("Enter the integer number: ");
                theInteger = int.Parse(Console.ReadLine());
            } while (theInteger <= 0 || theInteger > 100);

            for (int times = 1; times <= 10; times++)
            {
                product = theInteger * times;
                Console.WriteLine($"{theInteger} X {times} = {product}");
            }
        }
    }
}
