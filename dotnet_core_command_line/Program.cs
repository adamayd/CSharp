using System;

namespace dotnet_core_command_line
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = System.Environment.MachineName;
            Console.WriteLine("Hello " + name);
        }
    }
}
