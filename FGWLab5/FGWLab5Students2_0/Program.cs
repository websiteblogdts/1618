using System;

namespace FGWLab5Students2_0
{
    internal class Program
    {
        public static bool IsStudentExisting(List<Student> students, string firstName, string lastName)
        {
            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName) return true;
            }
            return false;
        }
        public static Student GetStudent(List<Student> students, string firstName, string lastName)
        {
            Student exitStudent = null;
            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    exitStudent = student;
                }
            }
            return exitStudent;
        }

        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string cmd1;
            int check;
            do
            {

                Console.WriteLine("Enter information of student (FirstName LastName Age City):");
                string[] student = Console.ReadLine().Split();
                string firstName = student[0];
                string lastName = student[1];
                string age = student[2];
                string city = student[3];

                if (IsStudentExisting(students, firstName, lastName))
                {
                    Student studentInfor = GetStudent(students, firstName, lastName);
                    studentInfor.FirstName = firstName;
                    studentInfor.LastName = lastName;
                    studentInfor.Age = age;
                    studentInfor.City = city;
                }
                else
                {
                    Student studentInfor = new Student();
                    studentInfor.FirstName = firstName;
                    studentInfor.LastName = lastName;
                    studentInfor.Age = age;
                    studentInfor.City = city;

                    students.Add(studentInfor);
                }

                Console.WriteLine("If you want to exit, type 'end' or don't select any buttons.");
                cmd1 = Console.ReadLine();

                check = String.Compare(cmd1, "end");
            } while (check != 0);
            Console.Write("Find student in: ");
            string cityType = Console.ReadLine();

            foreach (Student studentInfor in students)
            {
                if (studentInfor.City == cityType)
                {
                    Console.WriteLine($" {studentInfor.FirstName} {studentInfor.LastName} is {studentInfor.Age} years old");
                }
            }
        }
    }
}