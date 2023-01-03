using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FGWLab7PersonalEmployeeInheritant
{
    internal class EmployeeList
    {
        // ko co ke thua 
        private List<Employee> listOfEmployee= new List <Employee>();
        public EmployeeList()
        {
            listOfEmployee.Add(new Employee("A", "Nguyen", 20, 1000.57));
            listOfEmployee.Add(new Employee("B", "Nguyen", 20, 1000.57));
            listOfEmployee.Add(new Employee("C", "Nguyen", 20, 1000.57));
        }
        public void enterEmployeeToList(Employee tmpEmployee)
        {
            listOfEmployee.Add(tmpEmployee);
            Console.WriteLine("Done Added");
        }
        // day la ham  them Emplyee vao tu ban phim 
        public void addEmployee()
        {
            Employee tmpEmployee = new Employee();
            tmpEmployee = tmpEmployee.enterEmployee();
            listOfEmployee.Add(tmpEmployee);
            Console.WriteLine("Added");
        }
        public void displayEmployeeList()
        {
            foreach (Employee fingerEmployee in listOfEmployee)
            {
                fingerEmployee.employeeDetails();
            }
        }
        // day la ham sap xep List Employee theo First Name va Age
        public void displaySortedNameAge()
        {
            var sorted = listOfEmployee.OrderBy(p => p.FirstName).ThenBy(p => p.Age).ToList();
            Console.WriteLine(string.Join(Environment.NewLine, sorted));
        }
    }
}
