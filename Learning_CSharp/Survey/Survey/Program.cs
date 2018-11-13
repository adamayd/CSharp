using System;

namespace Survey
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name? ");
            var name = Console.ReadLine();

            Console.Write("How old are you? ");
            var age = Console.ReadLine();

            Console.Write("What month were you born in? ");
            var birthMonth = Console.ReadLine();

            Console.WriteLine("{0} is {1} years old and was born in the month of {2}", name, age, birthMonth);
        }
    }
}
