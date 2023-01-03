namespace FGWLab7PersonInheritantDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Person Inheritant Demo");

            Person person = new Person("Mr A","Da Nang");
            person.eating();
            person.sleeping();
            Console.WriteLine("-----------------------");
            Employee employee = new Employee("FGW");
            employee.name = "MR B";// duoc ke thua
            employee.address = "Ha Noi";// duoc ke thua
            employee.eating(); // duoc ke thua
            employee.sleeping();// duoc ke thua
            employee.workingAt();
            Console.WriteLine("-----------------------");
            Student student = new Student("Uni");
            student.name = "Mr C";
            student.address = "TP HCM";
            student.eating();
            student.sleeping();
            student.studyAt();

        }
    }
}