using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FGWLab7PersonalEmployeeInheritant
{
    class Employee : Person
    {
        public double Salary { get; set; }
        public Employee()
        {

        }
        public Employee(string firstName, string lastName, int age, double salary)
            : base(firstName, lastName, age)
        {
            Salary = salary;
        }
        //public void employeeDetails()
        //{
        //    Console.WriteLine($"Name: {FirstName} ");
        //    Console.WriteLine($"Age: {Age}");
        //    Console.WriteLine($"Salary: {Salary}");
        //}
        public Employee enterEmployee()
        {
            Employee tmp = new Employee();
            //minh tan dung ham enterPerson ke thua
            Person person = new Person();
            person = person.enterPerson();
            // sau do nhap them 1 bien Salary vao
            Console.WriteLine("Enter Salary: ");
            Salary = double.Parse(Console.ReadLine());
            // do person luc nay chua 3 thong tin va them Salary la 4 thong tin 
            tmp = new Employee(person.FirstName, person.LastName, person.Age, Salary);
            return tmp;
        }
        public void employeeDetails()
        {
            base.personDetails(); // cuc ke thua
            Console.WriteLine($"Salary: {Salary}");
        }

        public double increaseSalary(double percent)
        {
            // double tmpSalary;
            // luong 1000, tang 0.5%
            // luong = 1000 + 1000*0.5
            Salary = Salary + Salary * percent;
            return Salary;
        }
        public double increaseSalaryByAge(double percent)
        {
            double increaseAmount = Salary * percent;
            if (Age > 30)
            {
                this.Salary = this.Salary + increaseAmount / 100;
            }
            else
            {
                this.Salary = this.Salary + increaseAmount / 200;
            }
            return Salary;
        }

        public override string? ToString()
        {
            return base.ToString() + "Salary: " + Salary;
        }
    }
}
