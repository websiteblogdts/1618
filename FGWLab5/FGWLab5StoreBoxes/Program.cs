using System;

namespace FGWLab5StoreBoxes
{
    public class Program
    {
        static void Main(string[] args)
        {
            BoxList box = new BoxList();

            int result;
            string cmd1;
            do
            {

                box.EnterInfor();
                //box.AddInforToList();

                Console.WriteLine("If you want to exit, type 'end' or don't select any buttons.");
                cmd1 = Console.ReadLine();

                result = String.Compare(cmd1, "end");
            } while (result != 0);
            box.DisplayInfor();
        }
    }
}