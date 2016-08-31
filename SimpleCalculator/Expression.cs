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
                        stack.pushToMonkey(user_input);
                        stack.printMonkey();
                        foreach (string input in stack.monkey)
                        {
                            Console.WriteLine(stack.monkey);
                        }
                        return math.Add(firstDigit, secondDigit);
                    case "-":
                        stack.SetLastInput(user_input);
                        return math.Subtract(firstDigit, secondDigit);
                    case "*":
                        stack.SetLastInput(user_input);
                        return math.Multiply(firstDigit, secondDigit);
                    case "/":
                        stack.SetLastInput(user_input);
                        return math.Divide(firstDigit, secondDigit);
                    case "%":
                        stack.SetLastInput(user_input);
                        return math.Modulify(firstDigit, secondDigit);
                    default:
                        stack.SetLastInput(user_input);
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
    }
}
