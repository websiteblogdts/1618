using System;

namespace FGWLab5RandomizeWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array: ");
            string[] arr = Console.ReadLine().Split().ToArray();

            List<Words> words = new List<Words>();

            for (int i = 0; i < arr.Length; i++)
            {
                Words word = new Words();
                Random rnd = new Random();
                int a = rnd.Next(0, arr.Length - 1);
                word.Word = arr[a];
                words.Add(word);
            }
            foreach (Words word in words)
            {
                Console.WriteLine(word.Word);
            }
        }
    }
}