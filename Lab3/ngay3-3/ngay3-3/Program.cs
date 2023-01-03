using System;
using System.Collections.Generic;
namespace ngay3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program is about the list");
            List<int> numbers = new List<int>();
            int numberTmp;
            for (int i = 0; i < 5; i++) ;
            {
                Console.Write("Enter the element: ");
                numberTmp = int.Parse(Console.ReadLine());
                //add phan tu moi nhap tu ban phim
                numbers.Add(numberTmp);
            }
            //co the add binh thuong
            numbers.Add(98);
            // Hien thi collection thuong dung foreach
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }
            //chỗ ni là làm thêm string list
            //list of string
            List<string> authors = new List<string>(5);
            authors.Add("Mahesh Chand");
            authors.Add("Chris Love");
            authors.Add("Allen O'neill");
            authors.Add("Naveen Sharma");
            authors.Add("Mahesh Chand");
            authors.Add("Monica Rathbun");
            authors.Add("David McCarter");
            Console.WriteLine("Original List items");
            Console.WriteLine("================");
            foreach (string a in authors)
                Console.WriteLine(a);
            authors.Reverse();
            Console.WriteLine();
            Console.WriteLine("Sorted List items");
            Console.WriteLine("==================");
            foreach (string a in authors)
                Console.WriteLine(a);
        }
    }
}