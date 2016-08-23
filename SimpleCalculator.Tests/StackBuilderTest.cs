using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class StackBuilderTest
    {
        [TestMethod]
        public void SetInputTest()
        {
            StackBuilder stack = new StackBuilder();
            Assert.AreEqual("Nothing asked to be calculated yet.", stack.LastInput);
            stack.SetLastInput("Success!");
            Assert.AreEqual("Success!", stack.LastInput);
        }
        public void SetOutputTest()
        {
            StackBuilder stack = new StackBuilder();
            Assert.AreEqual("Nothing output yet.", stack.LastOutput);
            stack.SetLastInput("Success!");
            Assert.AreEqual("Success!", stack.LastOutput);
         }
    }
}
