using System;
using System.Runtime.InteropServices.ComTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Spoj1Divisor_SummationTests
{
    [TestClass()]
    public class TryParseTest
    {
        [TestMethod()]
        public void TryParseCorrecntess()
        {
            var myNumberInString = "33333333333333333333333333333333333";
            var number = 0;
            var isNumber = int.TryParse(myNumberInString, out number);

            Assert.AreNotEqual(isNumber,true);
            Assert.AreEqual(number, 0);
        }
    }
   
}
