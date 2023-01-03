using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FGWLab7PersonInheritantDemo
{
    internal class Employee:Person
    {
        //khai bao them 1 thuoc tinh ten la company
        public string company;
        public Employee(string company)
        {
            this.company = company;

        }
        public void workingAt()
        {
            Console.WriteLine($"The person is working at {company}");
        }
    }
}
