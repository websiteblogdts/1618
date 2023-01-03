using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5_driving
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Look like a good driver to carry out the object");
            Car car01 = new Car();
            car01.MakeYear = "2022";
            car01.Colour = "Green";
            car01.Model = "Toyota";

            car01.displayInformation();
            car01.accelerating();
            car01.driving();
            car01.braking();
          
            Console.WriteLine("==============");
            //dòng code này rút gọn thay cho code bên trên
            Car car02 = new Car("2000", "Vinfast", "Yellow");

            car02.displayInformation();
            car02.accelerating();
            car02.driving();
            car02.braking();
        }
    }
}

