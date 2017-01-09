using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Spoj1Divisor_SummationTests
{
    [TestClass]
    public class ParseTests
    {
        [TestMethod]
        public void TryParseIntCorrectnessTest()
        {
            var numberInString = "33333333333333333333333333333";
            int number;
            var isNumber = int.TryParse(numberInString,out number);

            Assert.AreNotSame(isNumber,true);
            Assert.AreEqual(number,0);
        }

        
    }
}
