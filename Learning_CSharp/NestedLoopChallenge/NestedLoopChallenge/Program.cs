using System;

namespace NestedLoopChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write(j + " ");
                }

                for (int j = 10; j != 0; j--)
                {
                    Console.Write(j + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
