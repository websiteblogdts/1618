using FGWlab07annimal;

namespace FGWLab7InheritantAnimalDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // tao ra mot con cho
            Dog dog = new Dog("dogA", "meat", "home", "Gow");
            Console.WriteLine($"The dog is {dog.ToString()}");
            dog.eatingFood();
            dog.bark();
            Console.WriteLine("----------------------------");
            // tinh chat da hanh 
            Cat cat = new Cat("cat", "meat", "home", "Meow");
            Console.WriteLine($"The cat is {cat.ToString()}");
            cat.eatingFood();
            cat.meow();
            Console.WriteLine("----------------------------");
            Puppy puppy = new Puppy();
            puppy.eatingFood();
            puppy.bark();
            puppy.weeping();
        }
    }
}