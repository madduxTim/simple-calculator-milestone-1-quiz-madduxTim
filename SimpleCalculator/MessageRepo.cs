using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class MessageRepo
    {
        StackBuilder stack = new StackBuilder();
        public string LastInputDisplay()
        {
            return stack.LastInput;
        }
        public string LastOutputDisplay()
        {
            return stack.LastOutput;
        }
        private string LogoutMsg { get; } = "Take care user!";
        public string BadInput { get; } = "Try entering again. Ex: 4 + 10";
        public string DisplayLogoutMsg()
        {
            return LogoutMsg; 
        }
    }

     
}
