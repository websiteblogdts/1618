using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5_driving
{
    class Car
    {
        private string makeYear;
        private string model;
        private string colour;

        public string MakeYear { get; set; }

        public string Model { get; set; }

        public string Colour { get; set; }

        public Car()
        {

        }

        public Car(string makeYear, string model, string colour)
        {
            MakeYear = makeYear;
            Model = model;
            Colour = colour;
        }

        public void driving()
        {
            Console.WriteLine("The car is Driving");
        }
        public void accelerating()
        {
            Console.WriteLine("The car is Accelerating");
        }
        public void braking()
        {
            Console.WriteLine("The car is Braking");
        }

        public void displayInformation()
        {
            Console.WriteLine($"The Car with colour: {Colour} and {MakeYear} and {Model}");
        }
        public override string? ToString()
        {
            return base.ToString();
        }
    }
}

