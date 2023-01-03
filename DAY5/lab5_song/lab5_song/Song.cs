using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace lab5_song
{
    internal class Song
    {
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
        public Song()
        { 

        }

        public Song(string typeList, string name, string time)
        {
            TypeList = typeList;
            Name = name;
            Time = time;
        }

        public Song enterSongToList()
        {
            Song tmpSong;
            Console.WriteLine("Enter the type list ");
            string tmpTL = Console.ReadLine();

            Console.WriteLine("Enter the Name: ");
            string tmpN = Console.ReadLine();

            Console.WriteLine("Enter the Time: ");
            string tmpT = Console.ReadLine();

            tmpSong= new Song(tmpTL, tmpN, tmpT);

            return tmpSong;
        }

        public override string? ToString()
        {
            return "The song is: "+TypeList +" "+Name + " "+Time ;
        }
    }
}
