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
        public string ExpressionHandler(string user_input)
        {
            //if (user_input == "last")
            //{
            //    return user_input;
            //}
            //if (user_input == "lastq") { } 
            if (user_input.Contains("+") && user_input.Length > 2 && user_input.Length < 10)
            {
                Addition add = new Addition();
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
                return "Try again";
            }
        }
    }
}
