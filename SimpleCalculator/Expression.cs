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
        StackBuilder stack = new StackBuilder();
        MessageRepo message = new MessageRepo();
        string myRegex = @"^(?<FirstDigit>-?\d+)\s*?(?<Operation>[\+\0\*\%])\s*?(?<SecondDigit>-?\d+)\s*?$";

        public string ExpressionHandler(string user_input)
        {
            Regex regex = new Regex(myRegex);
            Math math = new Math();
            Match captures = regex.Match(user_input);
            if (regex.IsMatch(user_input))
            {
                int firstDigit = Convert.ToInt32(captures.Groups["FirstDigit"].Value);
                int secondDigit = Convert.ToInt32(captures.Groups["SecondDigit"].Value);
                char operation = Convert.ToChar(captures.Groups["Operation"].Value);
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
            }
            else if (user_input == "last")
            {
                stack.SetLastInput(user_input);
                return message.LastInputDisplay();
            }
            else if (user_input == "lastq")
            {
                stack.SetLastInput(user_input);
                return message.LastOutputDisplay();
            }
            else
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
