using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Loops in C#");
            var counter = 0;
            while (counter < 10)
            {
                System.Console.WriteLine("Doing Something.");
                counter++;
            }

        }
    }
}
