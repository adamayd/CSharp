using System;
using System.Collections.Generic;

namespace GradeBook.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Adam's Grade Book");
            // book.AddGrade(89.1);
            // book.AddGrade(90.5);
            // book.AddGrade(77.5);
            // Please enter a grade.  Do in a loop until entering a "q"

            while (true)
            {
                System.Console.WriteLine("Please enter a grade or q to quit: ");
                var input = System.Console.ReadLine();

                if (input == "q")
                {
                    break;
                }

                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch(ArgumentException ex)
                {
                    System.Console.WriteLine(ex.Message);
                }
                catch(FormatException ex)
                {
                    System.Console.WriteLine(ex.Message);
                }
            }

            var stats = book.GetStatistics();

            System.Console.WriteLine($"The highest grade is {stats.High}");
            System.Console.WriteLine($"The lowest grade is {stats.Low}");
            System.Console.WriteLine($"The average grade is {stats.Average:N1}");
            System.Console.WriteLine($"The letter grade is {stats.Letter}");
        }
    }
}
