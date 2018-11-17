using System;

namespace Survey
{
    class Program
    {
        public static event Action Posted;

        static void Main(string[] args)
        {
            var stats = new Stats();
            stats.Start();

            var answers = new Answers();
            
            Console.Write("What is your name? ");
            answers.Name = TryAnswer();

            Console.Write("How old are you? ");
            answers.Age = int.Parse(TryAnswer());

            Console.Write("What month were you born in? ");
            answers.BirthMonth = TryAnswer();

            answers.Display();
            
            if (Posted != null)
                Posted();

            ZodiacSign.FindZodiac(answers.BirthMonth);
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
