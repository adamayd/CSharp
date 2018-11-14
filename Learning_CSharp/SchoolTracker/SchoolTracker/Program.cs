using System;

namespace SchoolTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentGrades = new int[] { 80, 77, 92, 68, 83, 85, 81, 79, 96, 100 };

            foreach (var student in studentGrades)
            {
                Console.WriteLine(student);
            }
        }
    }
}
