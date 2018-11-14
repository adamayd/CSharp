using System;

namespace Passcode
{
    class Program
    {
        static void Main(string[] args)
        {
            var passcode = "";

            while (passcode != "secret")
            {
                Console.Write("Enter the passcode: ");
                passcode = Console.ReadLine();

                if (passcode != "secret")
                {
                    Console.Clear();
                    Console.WriteLine("Incorrect passcode");
                }
            }

            Console.Clear();
            Console.WriteLine("You are authenticated");
        }
    }
}
