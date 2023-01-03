using System.Text;
using System;

namespace FGWLab6DigitsLettersAndOther
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stringEntered = Console.ReadLine();
            var number = new StringBuilder();
            var letters = new StringBuilder();
            var other = new StringBuilder();

            for (int i = 0; i < stringEntered.Length; i++)
            {
                // Separate every single char 
                var chartext = stringEntered[i];

                // Check to sort char to its type

                // char.IsDigit: check if it is a number
                if (char.IsDigit(chartext))
                {
                    // Append: add new one to the old string
                    number.Append(chartext);
                }
                // char.IsLetter: check if it is a letter
                else if (char.IsLetter(chartext))
                {
                    letters.Append(chartext);
                }
                else
                {
                    other.Append(chartext);
                }
            }
            Console.WriteLine($"{number}\n{letters}\n{other}");
        }
    }
}