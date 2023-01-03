using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5_song
{
    internal class Songlist
    {
        List<Song> listSongs = new List<Song>();

        public Songlist(List<Song> listsongs)
        {
            this.listSongs = listsongs;
        }
        public Songlist()
        {

        }

        public void enterSongToList()
        {
            Song tmpSong=new Song();
            Console.WriteLine("Number of song: ");
            int numberOfSong=int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfSong; i++)
            {
                tmpSong = tmpSong.enterSongToList();
                listSongs.Add(tmpSong);
                Console.WriteLine("Added");
            }

        }
        public void displaySongFromTheList()
        {
            Console.WriteLine("Display all the song in the list....");
            foreach (var eachSong in listSongs)
            {
                Console.WriteLine(eachSong.ToString());
            }
        }
    }
}
