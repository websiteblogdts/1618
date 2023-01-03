using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FGWLab7PersonInheritantDemo
{
    // viet ham de student thua ke person
    internal class Student:Person
    {
        //khai bao them thuoc tinh school cau student 
        //ham dung lai cua person
        public string school;

        public Student(string school)
        {
            this.school = school;
        }
        public void studyAt()
        {
            Console.WriteLine($"The person is study at {school}");
        }
    }
}
