using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class ExpressionTest
    {
        [TestMethod]
        public void ExpressionsTesting()
        {
            Expression exp = new Expression();
            //Multiplication blah = new Multiplication();
            string recognizeOperators = exp.ExpressionHandler("9 * 88");
            //Assert.IsTrue(blah.Multiply("9 * 88").Contains("*"));
            Assert.AreEqual("792", recognizeOperators);
            string errorMessage = exp.ExpressionHandler("h3ll0!");
            Assert.AreSame(errorMessage, "You didn't enter an equation correctly. Try again");
        }
    }
}
