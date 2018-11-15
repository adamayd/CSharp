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
                
                Console.Write("Name: ");
                newStudent.Name = (Console.ReadLine());

                Console.Write("Grade: ");
                newStudent.Grade = (int.Parse(Console.ReadLine()));
                
                Console.Write("Birthday: ");
                newStudent.Birthday = (Console.ReadLine());

                Console.Write("Address: ");
                newStudent.Address = (Console.ReadLine());
                
                Console.Write("Phone Number: ");
                newStudent.Phone = (Int64.Parse(Console.ReadLine()));

                students.Add(newStudent);

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
    }
    
    class Student
    {
        public string Name;
        public int Grade;
        public string Birthday;
        public string Address;
        public long Phone;
    }
}
