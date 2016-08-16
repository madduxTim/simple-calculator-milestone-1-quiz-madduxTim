using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sup slick? Go ahead and get your math on.");
               
            string linePrompt = "[0]>";
            Console.Write(linePrompt);
            string input = Console.ReadLine().ToLower();
            Console.WriteLine("Thanks, I'll try to... {0}", input);


            Console.ReadKey();
        }
    }
}
