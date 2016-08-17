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
        public static bool trigger { get; internal set; }

        static void Main(string[] args)
        {
            bool trigger = true;
            int counter = 0;
            while (trigger == true)
            {
                string linePrompt = "[" + counter + "]>";
                Console.Write(linePrompt);
                string input = Console.ReadLine().ToLower();
                counter += 1;
                if (input == "exit" | input == "quit")
                {
                    trigger = false;
                } else
                {
                    Expression exp = new Expression();
                    Console.WriteLine(exp.ExpressionHandler(input));
                }
                //Console.WriteLine($"Thanks, I'll try to... {input}");
            }
        }
    }
}

// info on Constants is under 'Getting Started with C# Programming Fundamentals in C# from Scratch