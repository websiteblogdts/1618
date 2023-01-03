namespace FGWLab6ReverseStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            while (command != "end")
            {
                string line = command;
                string reversed = "";
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    reversed += line[i];
                }

                Console.WriteLine($"{line} = {reversed}");
                command = Console.ReadLine();
            }
        }
    }
}