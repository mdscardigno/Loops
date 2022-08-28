using System;
using System.Collections.Generic;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Loops in C#");
            var whileCounter = 0;
            while (whileCounter < 10)
            {
                System.Console.WriteLine("While Loop: Doing Something.");
                whileCounter++;
            }

            //for(INITIALIZATION; CONDITION; AFTER THOUGHT){
            //LOOP STATEMENTS
            for (var forCounter = 0; forCounter < 10; forCounter++)
            {
                System.Console.WriteLine("For Loop: Do something.");
            }
            //how do we loop through a list?
            var names = new List<string>() { "Paula", "Mila", "Mario" };
            // 
            names.Add("Billy");
            names.Add("John");
            names.Add("Vincent");

            System.Console.WriteLine("What is your name?");
            var name = Console.ReadLine();

            names.Add(name);

            //as long as the name is not quit, I will print the list of names
            while (name != "quit")
            {
                System.Console.WriteLine($" -- {names.Count} People --");
                //print out the whole list of names
                //as we are actively executing the code, names.Count is changing
                // for (var index = 0; index < names.Count; index++)
                // {
                //     var currentName = names[index];// in lists we have index
                //     // System.Console.WriteLine(currentName);
                //     System.Console.WriteLine($"The person at index {index} is {currentName}");
                // }
                //foreach something in a collection
                //var currentName is the variable I want each item in the collection to be named and what is the name of the collection I am going through
                //i am missing a variable in the foreach, that is, the index. So if I need to use the index, foreach wont work.
                // foreach (var currentName in names)//simpler, goes through the collection one item at a time in order  
                // {
                //     System.Console.WriteLine(currentName);
                // }
                //if we do index > 0; we are gonna miss Paula so we use index >= 0;
                for (var index = names.Count - 1; index >= 0; index--)//homework shuffle //stack
                {
                    var currentName = names[index];// in lists we have index
                    System.Console.WriteLine($"The person at index {index} is {currentName}");
                }
                //this bellow will not work because there is no ReverseEach
                // names.Reverse();
                // foreach (var currentName in names)
                // {
                //     System.Console.WriteLine(currentName);
                // }
                System.Console.WriteLine();

                System.Console.WriteLine("What is your name?");
                name = Console.ReadLine();

                names.Add(name);
            }
            System.Console.WriteLine($"-- {names.Count} People");
        }
    }
}
