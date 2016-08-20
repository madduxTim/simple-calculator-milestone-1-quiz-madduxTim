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
            //string lastInput = "nothing yet hombre";
            //string lastOutput = "nothing to see here";
            bool trigger = true;
            int counter = 0;
            while (trigger == true)
            {
                string linePrompt = "[" + counter + "]> ";
                Console.Write(linePrompt);
                string input = Console.ReadLine().ToLower();
                counter += 1;
                if (input == "exit" | input == "quit")
                {
                    Console.WriteLine("Luego, hombre!");
                    trigger = false;
                }
                else
                {
                    Expression exp = new Expression();
                    Console.WriteLine("   = " + exp.ExpressionHandler(input));
                    //lastInput = input;
                    //lastOutput = exp.ExpressionHandler(input);
                }
            }
        }
    }
}

// info on Constants is under 'Getting Started with C# Programming Fundamentals in C# from Scratch