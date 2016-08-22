using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Division
    {
        public string Divide(string user_input)
        {
            int operandIndex = user_input.IndexOf("/");
            bool checking = user_input.EndsWith("/");
            if (operandIndex != 0 && checking == false)
            {
                string preOperand = user_input.Substring(0, operandIndex);
                string postOperand = user_input.Substring(operandIndex + 1);
                int firstDigit = int.Parse(preOperand);
                int secondDigit = int.Parse(postOperand);
                int output = firstDigit / secondDigit;
                return output.ToString();
            }
            else
            {
                return "Check your last entry. You need two digits between a operand.";
            }
        }
    }
}
