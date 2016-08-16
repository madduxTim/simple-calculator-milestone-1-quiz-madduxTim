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
            int counter = 0;
            string linePrompt = "[" + counter + "]>";
            Console.Write(linePrompt);
            string input = Console.ReadLine().ToLower();
            //Console.WriteLine("Thanks, I'll try to... {0}", input);
            counter += 1;
            //Console.WriteLine("[" + counter + "]>"); // this increments 
            //Console.WriteLine(linePrompt); // this does not 

            Expression exp = new Expression();
            Console.WriteLine(exp.ExpressionHandler(input));


            Console.ReadKey();
        }
    }
}
