namespace FGWLab6Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Enter string you want to delete
            string stringDelete = Console.ReadLine();

            // Enter the string
            string text = Console.ReadLine();

            // Find the first match index 
            // I enter "key" -> the first index is "k"
            int index = text.IndexOf(stringDelete);

            // match index (0) - no match index (-1)
            while (index != -1)
            {
                // textkey
                // First index [0] is k - key.Length = 3
                // Remove [0] [1] [2] <=> k e y 
                text = text.Remove(index, stringDelete.Length);
                // textkey
                // First index [4] is k - key.length = 3
                // Remove [4] [5] [6] <=> key
                index = text.IndexOf(stringDelete);
                // text
            }

            Console.WriteLine(text);
        }
    }
}