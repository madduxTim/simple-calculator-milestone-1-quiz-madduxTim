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
        Addition add = new Addition();
        Subtraction subtract = new Subtraction();
        Multiplication multiply = new Multiplication();
        Modulus modulify = new Modulus();
        Division divide = new Division();
        MessageRepo message = new MessageRepo();

        public string ExpressionHandler(string user_input)
        {
            if (user_input.Contains("+"))
            {
                return add.Add(user_input);
            }
            else if (user_input.Contains("-"))
            {
                return subtract.Subtract(user_input);
            }
            else if (user_input.Contains("*"))
            {
                return multiply.Multiply(user_input);
            }
            else if (user_input.Contains("%"))
            {
                return modulify.Modulify(user_input);
            }
            else if (user_input.Contains("/"))
            {
                return divide.Divide(user_input);
            }
            else
            {
                return message.BadInput;
            }
        }
    }
}
