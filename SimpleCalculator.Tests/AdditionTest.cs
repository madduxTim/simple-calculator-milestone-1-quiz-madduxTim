using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class AdditionTest
    {
        [TestMethod]
        public void canHandleAddExpressions()
        {
            Expression exp = new Expression();
            string fifteen = exp.ExpressionHandler("12 + 3");
            Assert.AreEqual("15", fifteen);
            string getMessage1 = exp.ExpressionHandler("+3");
            Assert.AreEqual(getMessage1, "Check your last entry. You need two digits between a operand.");
            string getMessage2 = exp.ExpressionHandler("3+");
            Assert.AreEqual(getMessage2, "Check your last entry. You need two digits between a operand.");
            string getMessage3 = exp.ExpressionHandler("h3ll0!");
            Assert.AreSame(getMessage3, "You didn't enter an equation correctly. Try again");
        }
    }
}
