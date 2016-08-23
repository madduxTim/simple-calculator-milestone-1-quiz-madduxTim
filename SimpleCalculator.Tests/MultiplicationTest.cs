using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class MultiplicationTest
    {
        [TestMethod]
        public void canHandleMultiplyExpressions()
        {
            Expression exp = new Expression();
            string twentyone = exp.ExpressionHandler("7 * 3");
            Assert.AreEqual("21", twentyone);
            string getMessage1 = exp.ExpressionHandler("*3");
            Assert.AreEqual(getMessage1, "Check your last entry. You need two digits between a operand.");
            string getMessage2 = exp.ExpressionHandler("3*");
            Assert.AreEqual(getMessage2, "Check your last entry. You need two digits between a operand.");
            string getMessage3 = exp.ExpressionHandler("h3ll0!");
            Assert.AreSame(getMessage3, "You didn't enter an equation correctly. Try again");
        }
    }
}
