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
            if (user_input.Contains("+"))
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
                return "The numbers you entered were too large or you entered the equation wrong. Try again";
            }
        }
    }
}
