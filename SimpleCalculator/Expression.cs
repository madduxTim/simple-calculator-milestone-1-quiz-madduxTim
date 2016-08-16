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
        public string ExpressionHandler(string user_input)
        {
            if (user_input.Contains("+"))
            {
                int where = user_input.IndexOf("+", 0, user_input.Length);
                Addition add = new Addition();
                return add.Add(user_input);
                
                //return where.ToString();
            } else 
            {
                return user_input + "nope";
            }
        }
    }
}
