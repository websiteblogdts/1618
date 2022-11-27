﻿using System;

namespace lab2_SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int number = i;
                int sum = 0;

                while (number > 0)
                {
                    int digit = number % 10;
                    sum += digit;
                    number /= 10;
                }

                bool isSpecialNumber = sum == 5 || sum == 7 || sum == 11;

                Console.WriteLine("{0} - > {1}", i, isSpecialNumber);
            }
        }
    }
}
