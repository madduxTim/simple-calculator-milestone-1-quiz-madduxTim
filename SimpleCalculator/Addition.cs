using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Addition
    {
        public string Add(string user_input)
        {
            MessageRepo message = new MessageRepo();
            int operandIndex = user_input.IndexOf("+");
            bool checking = user_input.EndsWith("+");
            if (operandIndex != 0 && checking == false)
            {
                string preOperand = user_input.Substring(0, operandIndex);
                string postOperand = user_input.Substring(operandIndex + 1);
                int firstDigit = int.Parse(preOperand);
                int secondDigit = int.Parse(postOperand);
                int output = firstDigit + secondDigit;
                return output.ToString();
            }
            else
            {
                return message.BadInput;
            }
        }
    }
}