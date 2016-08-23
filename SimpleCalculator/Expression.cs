using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace SimpleCalculator
{
    public class Expression
    {
        //StackBuilder stack = new StackBuilder(); 
        public string ExpressionHandler(string user_input)
        {
            if (user_input.Contains("+"))
            {
                Addition add = new Addition();
                //stack.SetLastOutput(add.Add(user_input)); // ASK WHY AS TO WHY THIS DIDN'T WORK, BUT DID THROW ERROR EITHER
                //Console.WriteLine("This is the expression handler " + add.Add(user_input)); //this prints as expected however...
                return add.Add(user_input);
            }
            else if (user_input.Contains("-"))
            {
                Subtraction subtract = new Subtraction();
                return subtract.Subtract(user_input);        
            }
            else if (user_input.Contains("*"))
            {
                Multiplication multiply = new Multiplication();
                return multiply.Multiply(user_input);
            }
            else if (user_input.Contains("%"))
            {
                Modulus modulify = new Modulus();
                return modulify.Modulify(user_input);
            }
            else if (user_input.Contains("/"))
            {
                Division divide = new Division();
                return divide.Divide(user_input);
            }
            else
            {
                return "You didn't enter an equation correctly. Try again";
            }
        }
    }
}
