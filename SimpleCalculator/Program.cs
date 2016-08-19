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
            //Stack stack = new Stack();
            string lastInput = "nothing yet hombre";
            string lastOutput = "nothing to see here";
            bool trigger = true;
            int counter = 0;
            while (trigger == true)
            {
                string linePrompt = "[" + counter + "]> ";
                Console.Write(linePrompt);
                string input = Console.ReadLine().ToLower();
                //stack.InputStack(input); // I need this to start creating a Stack with inputs from user. 
                counter += 1;
                if (input == "exit" | input == "quit")
                {
                    Console.WriteLine("Luego, hombre!");
                    trigger = false;
                }
                else if (input == "last")
                {
                    Console.WriteLine(lastInput);
                }
                else if (input == "lastq")
                {
                    Console.WriteLine(lastOutput);
                }
                else if (input.Count() <= 7)
                {
                    //Console.WriteLine(input.Count());
                    Expression exp = new Expression();
                    Console.WriteLine("   = " + exp.ExpressionHandler(input));
                    lastInput = input;
                    lastOutput = exp.ExpressionHandler(input);
                    //stack.OutputStack(exp.ExpressionHandler(input)); // I need this or something like it to start logging outputs.
                }           
                //else if (input == "last")
                //{
                //    foreach (var outputEntry in bacon)
                //    {
                //        Console.WriteLine(outputEntry);
                //    }
                //}
            }
        }
    }
}

// info on Constants is under 'Getting Started with C# Programming Fundamentals in C# from Scratch