using System;
using System.Collections.Generic;

namespace SchoolTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("How many students in your class? ");
            //var studentCount = int.Parse(Console.ReadLine());

            var students = new List<Student>();

            // replaced Lists below with List of Objects above
            //var studentNames = new List<string>();
            //var studentGrades = new List<int>();

            var adding = true;

            while (adding)
            {
                var newStudent = new Student();
                
                newStudent.Name = Util.Console.Ask("Name: ");

                newStudent.Grade = int.Parse(Util.Console.Ask("Grade: "));
                
                newStudent.Birthday = Util.Console.Ask("Birthday: ");

                newStudent.Address = Util.Console.Ask("Address: ");
                
                newStudent.Phone = Int64.Parse(Util.Console.Ask("Phone Number: "));

                students.Add(newStudent);
                Student.Count++;

                Console.Write("Add another? y/n ");
                if (Console.ReadLine().ToLower() != "y")
                    adding = false;

                Console.Clear();
            }

            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.Write("Name: ");
            //    studentNames[i] = Console.ReadLine();

            //    Console.Write("Grade: ");
            //    studentGrades[i] = int.Parse(Console.ReadLine());
            //}

            foreach (var student in students)
            {
                Console.WriteLine("Name: {0}, Grade: {1}", student.Name, student.Grade);
            }

            Console.WriteLine("{0} students", Student.Count);

            // *** Replaced for loop below with foreach above when moving to List of Student objects
            //for (int i = 0; i < studentNames.Count; i++)
            //{
            //    Console.WriteLine("Name: {0}, Grade: {1}", studentNames[i], studentGrades[i]);
            //}

            //foreach (var student in studentGrades)
            //{
            //    Console.WriteLine(student);
            //}
        }

        static void Import()
        {
            var importedStudent = new Student("Jack", 62, "Oct 17", "123 Main Street", 5551234567);
            Console.WriteLine(importedStudent.Name);
        }
    }

    class Member
    {
        public string Name;
        public string Address;
        protected long phone;

        public long Phone
        {
            set { phone = value; }
        }
    }
    
    class Student : Member
    {
        static public int Count = 0;

        public int Grade;
        public string Birthday;

        public Student()
        {

        }

        public Student(string name, int grade, string birthday, string address, long phone)
        {
            Name = name;
            Grade = grade;
            Birthday = birthday;
            Address = address;
            Phone = phone;
        }

        //    public void SetPhone(long number)
        //    {
        //        phone = number;
        //    }
    }

    class Teacher : Member
    {
        public string Subject;
    }
}
