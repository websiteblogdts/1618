using System;

namespace FGWLab5Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of songs: ");
            int n = int.Parse(Console.ReadLine());

            List<Song> songs = new List<Song>();

            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine("Enter Data:");
                string[] data = Console.ReadLine().Split("_");

                string type = data[0];
                string name = data[1];
                string time = data[2];

                Song song = new Song()
                {

                    TypeList = type,
                    Name = name,
                    Time = time
                };
                songs.Add(song);
            }
            string typelist = Console.ReadLine();
            if (typelist == "all")
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (Song song in songs)
                {
                    if (song.TypeList == typelist)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
        }
    }




}