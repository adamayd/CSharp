﻿using System;
using System.Collections.Generic;

namespace GradeBook.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            IBook book = null;

            book = EnterBookName(book);

            book.GradeAdded += OnGradeAdded;

            EnterGrades(book);

            var stats = book.GetStatistics();

            System.Console.WriteLine($"For the book named {book.Name}");
            System.Console.WriteLine($"The highest grade is {stats.High}");
            System.Console.WriteLine($"The lowest grade is {stats.Low}");
            System.Console.WriteLine($"The average grade is {stats.Average:N1}");
            System.Console.WriteLine($"The letter grade is {stats.Letter}");
        }

        private static IBook EnterBookName(IBook book)
        {
            while (true)
            {
                System.Console.WriteLine("Please enter a name for the grade book: ");
                var input = System.Console.ReadLine();

                try
                {
                    book = new DiskBook(input);
                }
                // TODO: add exception for blank input back in.
                catch (ArgumentException ex)
                {
                    System.Console.WriteLine(ex.Message);
                }

                if (!String.IsNullOrEmpty(input))
                {
                    break;
                }
            }

            return book;
        }

        private static void EnterGrades(IBook book)
        {
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
                catch (ArgumentException ex)
                {
                    System.Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    System.Console.WriteLine(ex.Message);
                }
            }
        }

        static void OnGradeAdded(object sender, EventArgs args)
        {
            System.Console.WriteLine("A grade was added!");
        }
    }
}
