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
        string myRegex = @"^(?<FirstDigit>-?\d+)\s*?(?<Operation>[\+\0\*\%])\s*?(?<SecondDigit>-?\d+)\s*?$";

        public string ExpressionHandler(string user_input)
        {
            Regex regex = new Regex(myRegex);
            Math math = new Math();
            Match captures = regex.Match(user_input);
            int firstDigit = Convert.ToInt32(captures.Groups["FirstDigit"].Value);
            int secondDigit = Convert.ToInt32(captures.Groups["SecondDigit"].Value);
            char operation = Convert.ToChar(captures.Groups["Operation"].Value);
            if (regex.IsMatch(user_input))
            {
                switch (operation.ToString())
                {
                    case "+":
                        return math.Add(firstDigit, secondDigit);
                    case "-":
                        return math.Subtract(firstDigit, secondDigit);
                    case "*":
                        return math.Multiply(firstDigit, secondDigit);
                    case "/":
                        return math.Divide(firstDigit, secondDigit);
                    case "%":
                        return math.Modulify(firstDigit, secondDigit);
                    default:
                        return message.BadInput;
                }
            } else
            {
                return message.BadInput;
            }    
        }




            //if (regex.IsMatch(user_input))
            //{
            //    return math.Add(firstDigit, secondDigit);
            //}
            //else
            //{
            //    return message.BadInput;
            //}

        //public string ExpressionHandler(string user_input)
        //{
        //if (user_input.Contains("+"))
        //{
        //    return add.Add(user_input);
        //}
        //else if (user_input.Contains("-"))
        //{
        //    return subtract.Subtract(user_input);
        //}
        //else if (user_input.Contains("*"))
        //{
        //    return multiply.Multiply(user_input);
        //}
        //else if (user_input.Contains("%"))
        //{
        //    return modulify.Modulify(user_input);
        //}
        //else if (user_input.Contains("/"))
        //{
        //    return divide.Divide(user_input);
        //}
        //else
        //{
        //    return message.BadInput;
        //}
        //    }
    }
}
