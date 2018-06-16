using System;

// Namespace
namespace NumberGuesser
{
    // Main Class
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {
            GetAppInfo(); // Run AppInfo function

            string inputName = GreetUser(); // Ask users name and greet

            while (true)
            {
                // set random number
                //int correctNumber = 7;

                // create a new random object
                Random randomNum = new Random();

                // set random number
                int correctNumber = randomNum.Next(1, 10);

                // set guess number
                int guess = 0;

                // write instrutions
                Console.WriteLine("Guess a number between 1 and 10");

                // while guess is not correct
                while (guess != correctNumber)
                {
                    //Get users input
                    string guessInput = Console.ReadLine();

                    // make sure guessInput is a number
                    if (!int.TryParse(guessInput, out guess))
                    {
                        //print error message
                        PrintColorMessage(ConsoleColor.Red, guessInput + " is not a number");

                        // keep going after error
                        continue;
                    }

                    // cast to int and put in guess
                    guess = Int32.Parse(guessInput);

                    // match guess to correct number
                    if (guess != correctNumber)
                    {
                        //write out incorrect number
                        PrintColorMessage(ConsoleColor.Red, "Incorrect Number, Guess Again");
                    }
                }

                // output success message
                PrintColorMessage(ConsoleColor.Yellow, "You guessed the correct number of " + correctNumber + ", Way to go " + inputName);

                // ask to play again
                Console.WriteLine("Play again? (y/n)");

                // get the answer
                string answer = Console.ReadLine().ToUpper();

                // check for answer
                if(answer == "Y")
                {
                    continue;
                }
                return;
            }
        }

        // get and display app info
        static void GetAppInfo()
        {
            // Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Adam Ayd";

            // change text color
            Console.ForegroundColor = ConsoleColor.Green;

            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // reset color
            Console.ResetColor();
        }

        // Ask users name and greet
        static string GreetUser()
        {
            // ask users name
            Console.WriteLine("What is your name?");

            // get user input
            string inputName = Console.ReadLine();

            // output greeting
            Console.WriteLine("Hello {0}, Let's Play a Game!", inputName);

            return inputName;
        }

        // print color message 
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            // change text color
            Console.ForegroundColor = color;

            // write out success message
            Console.WriteLine(message);

            // reset the console color
            Console.ResetColor();
        }
    }
}
