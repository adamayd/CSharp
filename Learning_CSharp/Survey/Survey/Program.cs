using System;

namespace Survey
{
    class Program
    {
        static void Main(string[] args)
        {
            var answers = new Answers();
            
            Console.Write("What is your name? ");
            answers.Name = TryAnswer();

            Console.Write("How old are you? ");
            answers.Age = int.Parse(TryAnswer());

            Console.Write("What month were you born in? ");
            answers.BirthMonth = TryAnswer();

            answers.Display();

            switch (answers.BirthMonth.ToLower())
            {
                case "january":
                    Console.WriteLine("You are a Capricorn");
                    break;
                case "february":
                    Console.WriteLine("You are an Aquarius");
                    break;
                case "march":
                    Console.WriteLine("You are a Pices");
                    break;
                case "april":
                    Console.WriteLine("You are an Aries");
                    break;
                case "may":
                    Console.WriteLine("You are a Taurus");
                    break;
                case "june":
                    Console.WriteLine("You are a Gemini");
                    break;
                case "july":
                    Console.WriteLine("You are a Cancer");
                    break;
                case "august":
                    Console.WriteLine("You are a Leo");
                    break;
                case "september":
                    Console.WriteLine("You are a Virgo");
                    break;
                case "october":
                    Console.WriteLine("You are a Libra");
                    break;
                case "november":
                    Console.WriteLine("You are a Scorpio");
                    break;
                default:
                    Console.WriteLine("You are a Sagittarius");
                    break;
            }
        }

        static string TryAnswer()
        {
            var answer = Console.ReadLine();

            if (answer == "")
            {
                Console.WriteLine("Your answer cannot be blank");
                return Console.ReadLine();
            }

            return answer;
        }
    }

    class Answers
    {
        public string Name;
        public int Age;
        public string BirthMonth;

        public void Display()
        {
            Console.WriteLine("{0} is {1} years old and was born in the month of {2}", Name, Age, BirthMonth);
        }
    }
}
