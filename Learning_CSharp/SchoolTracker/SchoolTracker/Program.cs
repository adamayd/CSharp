using System;
using System.Collections.Generic;

namespace SchoolTracker
{
    enum EnumSchool
    {
        Hogwarts,
        Harvard,
        MIT
    }

    class Program
    {
        static List<Student> students = new List<Student>();

        static void Main(string[] args)
        {
            Logger.Log("Tracker started", priority: 0);

            PayRoll payroll = new PayRoll();
            payroll.PayAll();

            var adding = true;

            while (adding)
            {
                try
                {
                    Logger.Log("Adding New Student");

                    var newStudent = new Student();

                    newStudent.Name = Util.Console.Ask("Name: ");

                    newStudent.Grade = Util.Console.AskInt("Grade: ");

                    newStudent.School = (EnumSchool) Util.Console.AskInt("School (type the corresponding number): \n  0: Hogwarts\n  1: Harvard\n  2: MIT\n");

                    newStudent.Birthday = Util.Console.Ask("Birthday: ");

                    newStudent.Address = Util.Console.Ask("Address: ");

                    newStudent.Phone = Util.Console.AskLong("Phone Number: ");

                    students.Add(newStudent);
                    Student.Count++;

                    Console.Write("Add another? y/n ");
                    if (Console.ReadLine().ToLower() != "y")
                        adding = false;

                    Console.Clear();

                }
                catch (FormatException msg)
                {
                    Console.Clear();
                    Console.WriteLine(msg.Message);
                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("Error adding student, Please try again");
                }
            }

            try
            {
                ShowGrade("Tom");
            }
            catch (Exception)
            {
                Console.WriteLine("Student Tom Not Found");
            }

            foreach (var student in students)
            {
                Console.WriteLine("Name: {0}, Grade: {1}", student.Name, student.Grade);
            }

            Console.WriteLine(Student.Count + (Student.Count == 1 ? " student" : " students"));

            Exports();
        }

        static void Import()
        {
            var importedStudent = new Student("Jack", 62, "Oct 17", "123 Main Street", 5551234567);
            Console.WriteLine(importedStudent.Name);
        }

        static void Exports()
        {
            foreach (var student in students)
            {
                switch (student.School)
                {
                    case EnumSchool.Hogwarts:
                        Console.WriteLine("Exporting to Hogwarts");
                        break;
                    case EnumSchool.Harvard:
                        Console.WriteLine("Exporting to Harvard");
                        break;
                    case EnumSchool.MIT:
                        Console.WriteLine("Exporting to MIT");
                        break;
                }
            }
        }

        static void ShowGrade(string name)
        {
            var found = students.Find(student => student.Name == name);
            Console.WriteLine("{0}'s Grade: {1}", found.Name, found.Grade);
        }
    }

    class Member
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public long Phone { get; set; }
    }
    
    class Student : Member
    {
        static public int Count { get; set; } = 0;

        public int Grade { get; set; }
        public string Birthday { get; set; }
        public EnumSchool School { get; set; }

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
}
