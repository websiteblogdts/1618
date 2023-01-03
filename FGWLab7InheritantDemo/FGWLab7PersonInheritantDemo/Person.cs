using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FGWLab7PersonInheritantDemo
{
    public class Person
    {
        // trong dong goi du lieu
        // khai bao 1 thuoc tinh neu muon ke thua 
        // 1: khai bao public
        // 2: khai bao quyen truy cap cua bien la protected
        public string name;
        public string address;
        //thieu ham dung ko co doi so
        public Person()
        {
             
        }
        public Person(string name, string address)
        {
            this.name = name;
            this.address = address;
        }

        // Viet 1 ham dung chung
        public void eating() 
        {
            Console.WriteLine($"the person {name} is eating");

        }

        // Viet 1 ham dung chung
        public void sleeping()
        {
            Console.WriteLine($"The person is sleeping at {address}");
        }
    }
}
