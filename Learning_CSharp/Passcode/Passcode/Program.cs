using System;

namespace Passcode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the passcode: ");
            var passcode = Console.ReadLine();

            if (passcode.ToLower() == "secret")
            {
                Console.WriteLine("You are authenticated");
            }
            else if (passcode.ToLower() != "secret")
            {
                Console.WriteLine("Incorrect passcode");
            }
        }
    }
}
