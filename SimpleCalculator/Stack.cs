using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Stack
    {
        public void InputStack(string user_input)
        {
            Stack<string> stack = new Stack<string>();
            stack.Push(user_input);
        }
        public void OutputStack(string output)
        {
            Stack<string> stack = new Stack<string>();
            stack.Push(output);
        }
    }
}
