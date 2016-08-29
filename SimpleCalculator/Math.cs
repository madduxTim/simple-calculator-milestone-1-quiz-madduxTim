using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Math
    {
        public string Add(int first, int second)
        {
            return Convert.ToString(first + second);
        }
        public string Subtract(int first, int second)
        {
            return Convert.ToString(first - second);
        }
        public string Multiply(int first, int second)
        {
            return Convert.ToString(first * second);
        }
        public string Divide(int first, int second)
        {
            return Convert.ToString(first / second);
        }
        public string Modulify(int first, int second)
        {
            return Convert.ToString(first % second);
        }
    }
}
