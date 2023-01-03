using System;

namespace SigOfIntegerNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int number = int.Parse(Console.ReadLine());
            int checkNumber = checkSigOfIntegerNumber(number);
            if (checkNumber== 0)
            {
                Console.WriteLine("The number is Zero");
            }else if (checkNumber>0)
            {
                Console.WriteLine("The number is positive");
            }
            else
            {
                Console.WriteLine("The number negative ");
            }
        }

        public static int checkSigOfIntegerNumber(int number)
        {


            int result;
            if (number >0)
            {
                result = 1;
            }else if(number<0)
            {
                result = -1;
            }else
            {
                result = -0;
            }
            return result;  
        }
    }
}