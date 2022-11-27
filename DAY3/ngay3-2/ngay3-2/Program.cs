using System;
using System.Linq;

namespace Ngay3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Khai Bao Bien
            int evenSum = 0, oddSum = 0, currentNumber, differenceValue;
            Console.WriteLine("Enter the integer arrays: ");
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            //Duyet Cac Phan Tu
            for (int i = 0; i < numbers.Length; i++)
            {
                currentNumber = numbers[i];
                if (currentNumber%2==0)
                {
                    evenSum = evenSum + currentNumber;

                }
                else //so le
                {
                    oddSum = oddSum + currentNumber;
                }
            }
            differenceValue = evenSum - oddSum;
            Console.WriteLine($"The difference between the even {evenSum} and odd array {oddSum} is {differenceValue}. ");
        }
    }
}