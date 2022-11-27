using System;

namespace ngay4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double gradeNumber;
            string gradeValue;
            gradeNumber = enterNumber();

            gradeValue = printGrades(gradeNumber);
            Console.WriteLine($" The grade number is: {gradeNumber}, the grade value is {gradeValue} ");
      
        }


        public static double enterNumber()
        {
            double tmpNumber;
            do
            {
                Console.Write("Enter a number between 2.00 and 6.00: ");
                tmpNumber = double.Parse(Console.ReadLine());
            } while (tmpNumber<2 || tmpNumber>6);
            
            return tmpNumber;
        }

        public static string printGrades(double grade)
        {
            string gradeValue;

            if (grade >= 2 && grade <= 2.99)
            {
                gradeValue = "Faill";

            } else if (grade <= 3.49)
            {
                gradeValue = "Poor";

            } else if (grade <= 4.49)
            {
                gradeValue = "Good";
            }
            else if (grade <= 5.49)
            {
                gradeValue = "Very Good";
            }
            else
            {
                gradeValue = "Excellent";
            }
            return gradeValue;

        }
    }
}