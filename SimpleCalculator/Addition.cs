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
            Console.WriteLine(preOperand);
            string output = user_input + "+";
            return output; 
        }
    }
}
