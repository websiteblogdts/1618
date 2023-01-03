using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FGWLab7InheritantAnimalDemo
{
    public class Dog:Animal
    {
        protected string sound;
        public Dog() 
        {

        }
        public Dog(string name, string food, string inhabitant,string sound)
            :base(name,food,inhabitant)// ke thua ham dung tu lop cha

        {
            this.sound = sound;
            
        }

        public void bark()
        {
            Console.WriteLine($"The dog bark: {sound}");
        }
        // ke thua roi 
        public override string ToString()
        {
            // cho ni ke thua tu cha
            // chu y base
            return base.ToString()+" bark "+sound;
        }
    }
}
