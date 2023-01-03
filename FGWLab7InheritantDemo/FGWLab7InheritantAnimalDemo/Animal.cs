using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FGWLab7InheritantAnimalDemo
{
    public class Animal
    {
        // khai bao cac thuoc tinh 
        // quyen truy cap o cac bien trong lop cha
        // set up lai cho lop cho con truy cap 
        protected string name;
        protected string food;
        protected string inhabitant;

        public Animal()
        {

        }
        // day la ham dung co 3 tham so truyen vao de tao 1 doi tuong cha
        public Animal(string name, string food, string inhabitant)
        {
            this.name = name;
            this.food = food;
            this.inhabitant = inhabitant;
        }
        // viet ham de thua ke
        public void eatingFood()
        {
            Console.WriteLine($"Animal eating {food}");

        }
        public override string? ToString()
        {
            return "Animal name " + name + " eat " + food + " food " + inhabitant;
        }
    }
}
