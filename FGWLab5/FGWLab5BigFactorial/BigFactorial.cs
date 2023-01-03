using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace FGWLab5BigFactorial
{
    internal class BigFactorial
    {
        public BigInteger value { get; set; }

        public BigFactorial()
        {

        }
        public void calculateBigFactorial()
        {
            Console.WriteLine("Enter number:");
            int number = int.Parse(Console.ReadLine());

            BigInteger result = 1;

            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }
            Console.WriteLine(result);
        }
    }
}
