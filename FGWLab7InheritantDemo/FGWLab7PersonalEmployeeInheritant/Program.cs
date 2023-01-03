namespace FGWLab7PersonalEmployeeInheritant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeList mylist = new EmployeeList();
            //mylist.displayEmployeeToList();
            Employee newEmp1 = new Employee("D", "Nguyen", 20, 2000);
            Employee newEmp2 = new Employee("E", "Nguyen", 90, 2000);
            Employee newEmp3 = new Employee("E", "Nguyen", 40, 2000);
            //newEmp2.increaseSalary(0.5);
            //newEmp3.employeeDetails();
            //newEmp3.increaseSalaryByAge(0.9);
            //Console.WriteLine("Increase Salary....");
            //newEmp3.employeeDetails();
            mylist.enterEmployeeToList(newEmp1);
            mylist.enterEmployeeToList(newEmp2);
            mylist.enterEmployeeToList(newEmp3);
            Console.WriteLine("------------------------------------");
            mylist.displayEmployeeList();
            mylist.enterEmployeeToList(new Employee("Cuong", "Huynh", 40,2000));
            mylist.addEmployee();
            Console.WriteLine("------------------------------------");
            mylist.displaySortedNameAge();
        }
    }
}