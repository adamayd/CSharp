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

            if(birthMonth.ToLower() == "january")
            {
                Console.WriteLine("You are a Capricorn");
            }
            else if(birthMonth.ToLower() == "february")
            {
                Console.WriteLine("You are an Aquarius");
            }
            else if(birthMonth.ToLower() == "march")
            {
                Console.WriteLine("You are a Pices");
            }
            else if(birthMonth.ToLower() == "april")
            {
                Console.WriteLine("You are an Aries");
            }
            else if(birthMonth.ToLower() == "may")
            {
                Console.WriteLine("You are a Taurus");
            }
            else if(birthMonth.ToLower() == "june")
            {
                Console.WriteLine("You are a Gemini");
            }
            else if(birthMonth.ToLower() == "july")
            {
                Console.WriteLine("You are a Cancer");
            }
            else if(birthMonth.ToLower() == "august")
            {
                Console.WriteLine("You are a Leo");
            }
            else if(birthMonth.ToLower() == "september")
            {
                Console.WriteLine("You are a Virgo");
            }
            else if(birthMonth.ToLower() == "october")
            {
                Console.WriteLine("You are a Libra");
            }
            else if(birthMonth.ToLower() == "november")
            {
                Console.WriteLine("You are a Scorpio");
            }
            else if(birthMonth.ToLower() == "december")
            {
                Console.WriteLine("You are a Sagittarius");
            }
        }
    }
}
