using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FGWLab7PersonalEmployeeInheritant
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Person()
        {

        }

        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
        //public Person enterPerson()
        //{
        //    Person tmp = new Person();
        //    Console.WriteLine("Enter first Name: ");
        //    FirstName = Console.ReadLine();
        //    Console.WriteLine("Enter last Name: ");
        //    LastName = Console.ReadLine();
        //    Console.WriteLine("Enter Age: ");
        //    Age = int.Parse(Console.ReadLine());
        //    tmp = new Person(FirstName, LastName, Age);
        //    return tmp;
        //}

        public Person enterPerson()
        {
            Person tmp = new Person();
            Console.WriteLine("Enter first Name: ");
            FirstName = Console.ReadLine();
            Console.WriteLine("Enter last Name: ");
            LastName = Console.ReadLine();
            Console.WriteLine("Enter Age: ");
            Age = int.Parse(Console.ReadLine());
            //Goi ham dung de tao ra Person
            tmp = new Person(FirstName, LastName, Age);
            //tra ve person
            return tmp;

        }
        public void personDetails()
        {
            Console.WriteLine($"Name: {FirstName} ");
            Console.WriteLine($"Age: {Age}");
        }

        public override string? ToString()
        {
            return "Person:" + FirstName + "Age: " + Age;
        }
    }
}
