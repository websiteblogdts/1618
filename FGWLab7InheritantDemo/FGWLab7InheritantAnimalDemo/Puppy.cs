using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FGWLab7InheritantAnimalDemo;

namespace FGWlab07annimal
{
    public class Puppy : Dog 
    {
        public Puppy()
        {

        }

        public void weeping()
        {
            Console.WriteLine("The puppy is weeping");
        }

        public void eating()
        {
            Console.WriteLine("The puppy is eating");
        }

        public void bark() 
        {
            Console.WriteLine("The puppy is bark"); 
        }

    }
}
