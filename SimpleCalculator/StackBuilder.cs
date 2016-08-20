using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace SimpleCalculator
{
    public class StackBuilder
    {
        public string LastEntry { get; set; }
        public void InputStack(string user_input)
        {
            Stack<string> stack = new Stack<string>();
            stack.Push(user_input);
            for (int i = 0; i < stack.Count(); i++)
            {
                LastEntry = stack.ElementAt(i - 1);
            }
            //GetEnumerator() method?
    }
        public string LastOutput { get; set; }
        public void OutputStack(string output)
        {
            Stack<string> stack = new Stack<string>();
            stack.Push(output);
            for (int i = 0; i < stack.Count(); i++)
            {
                LastOutput = stack.ElementAt(i - 1); 
            }
        }
    }
}
