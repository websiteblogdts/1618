using System;

namespace FGWLab5Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            string cmd1;
            int result;

            do
            {

                Console.WriteLine("Enter information of student (FN LN A C):");
                string[] student = Console.ReadLine().Split();

                string firstName = student[0];
                string lastName = student[1];
                string age = student[2];
                string city = student[3];
                Student inforStudent = new Student()
                {

                    FirstName = firstName,
                    LastName = lastName,
                    Age = age,
                    City = city
                };
                students.Add(inforStudent);

                Console.WriteLine("If you want to end (enter 'end'), or no press any button");
                cmd1 = Console.ReadLine();

                result = String.Compare(cmd1, "end");
            } while (result != 0);

            Console.Write("Find student in: ");
            string cityType = Console.ReadLine();

            foreach (Student inforStudent in students)
            {
                if (inforStudent.City == cityType)
                {
                    Console.WriteLine($"{inforStudent.FirstName} {inforStudent.LastName} is {inforStudent.Age} years old");
                }
            }
        }
    }
}