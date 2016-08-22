using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Addition
    {
        public string Add(string user_input)
        {
            int operandIndex = user_input.IndexOf("+");
            string preOperand = user_input.Substring(0, operandIndex);
            string postOperand = user_input.Substring(operandIndex + 1);
            Console.WriteLine(postOperand);
            if (operandIndex != 0 )
            {
                int firstDigit = int.Parse(preOperand);
                int secondDigit = int.Parse(postOperand);
                int output = firstDigit + secondDigit;
                return output.ToString();
            }
            else
            {
                return "Check your last entry. You need two digits between a operand.";
            }
        }
    }
}