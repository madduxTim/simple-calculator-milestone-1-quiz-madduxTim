using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using SimpleCalculator;

namespace SimpleCalculator
{
    public class Expression
    {
        public string ExpressionMaker(string user_input)
        {
            if (user_input.Contains("+"))
            {
                Addition add = new Addition();
                return add.Add(user_input);
            } else
            {
                return user_input + "nope";
            }
        }
    }
}
