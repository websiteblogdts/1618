using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FGWLab7InheritantAnimalDemo
{
    public class Cat : Animal
    {
        protected string sound;
        public Cat()
        {

        }

        public Cat(string name, string food, string inhabitant, string sound)
            : base(name, food, inhabitant)

        {
            this.sound = sound;

        }

        public void meow()
        {
            Console.WriteLine($"The cat meow: {sound}");
        }
        public override string ToString()
        {
            return base.ToString() + " meow " + sound;
        }
    }
}
