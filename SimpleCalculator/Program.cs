using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleCalculator;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool trigger = true;
            while (trigger == true)
            {
                int counter = 0;
                string linePrompt = "[" + counter + "]>";
                Console.Write(linePrompt);
                string input = Console.ReadLine().ToLower();
                if (input == "exit" | input == "quit")
                {
                    trigger = false;
                } else
                {
                    Expression exp = new Expression();
                    Console.WriteLine(exp.ExpressionHandler(input));
                    //Console.ReadKey();
                    counter += 1;
                }
                //Console.WriteLine($"Thanks, I'll try to... {input}");
                //Console.WriteLine("[" + counter + "]>"); // this increments 
                //Console.WriteLine(linePrompt); // this does not ui
            }
        }
    }
}

// review do while loop. That maybe what I need to build here. do the following ... until user var blah != true; And the thing that flips it to false is the words exit or quit, etc. 
// info on Constants is under 'Getting Started with C# Programming Fundamentals in C# from Scratch

    // string selection - string.Empty;
    // while (selection != "q" && selection != "Q")
    //{
    //    blah
    //}
