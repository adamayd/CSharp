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

            var studentNames = new List<string>();
            var studentGrades = new List<int>();

            var adding = true;

            while (adding)
            {
                Console.Write("Name: ");
                studentNames.Add(Console.ReadLine());

                Console.Write("Grade: ");
                studentGrades.Add(int.Parse(Console.ReadLine()));

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

            for (int i = 0; i < studentNames.Count; i++)
            {
                Console.WriteLine("Name: {0}, Grade: {1}", studentNames[i], studentGrades[i]);
            }

            //foreach (var student in studentGrades)
            //{
            //    Console.WriteLine(student);
            //}
        }
    }
}
