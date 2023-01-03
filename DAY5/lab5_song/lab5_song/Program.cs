namespace lab5_song
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*song song = new song("ABC", "Song01", "8-3-2001");
            Console.WriteLine(song.ToString());*/

            Songlist myList= new Songlist();
            myList.enterSongToList();
            myList.displaySongFromTheList();
        }
    }
}