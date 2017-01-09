using Microsoft.VisualStudio.TestTools.UnitTesting;
using Spoj1Divisor_Summation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spoj1Divisor_Summation.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void Divisor_Sumation_Result_Correctness_Test()
        {
            // Arrange
            var consoleInput = new StringReader(InputTestData());
            var consoleOutput = new StringBuilder();

            //Act
            Program.DivisorSumation(consoleInput, new StringWriter(consoleOutput));

            // Assert
            var actualResult = consoleOutput.ToString();

            Assert.AreEqual(ExpectedResult(), actualResult);
        }

        private static string ExpectedResult()
        {
            var expectedResult = new StringBuilder();
            expectedResult.AppendLine("0");
            expectedResult.AppendLine("1");
            expectedResult.AppendLine("1");
            expectedResult.AppendLine("3");
            expectedResult.AppendLine("1");
            expectedResult.AppendLine("6");
            expectedResult.AppendLine("1");
            expectedResult.AppendLine("7");
            expectedResult.AppendLine("4");
            expectedResult.AppendLine("8");
            expectedResult.AppendLine("1");
            expectedResult.AppendLine("16");
            expectedResult.AppendLine("1");
            expectedResult.AppendLine("10");
            expectedResult.AppendLine("9");
            expectedResult.AppendLine("15");
            expectedResult.AppendLine("1");
            expectedResult.AppendLine("21");
            expectedResult.AppendLine("1");
            expectedResult.AppendLine("22");
            expectedResult.AppendLine("11");
            expectedResult.AppendLine("14");
            expectedResult.AppendLine("1");
            expectedResult.AppendLine("36");
            expectedResult.AppendLine("6");
            expectedResult.AppendLine("16");
            expectedResult.AppendLine("13");
            expectedResult.AppendLine("28");
            expectedResult.AppendLine("1");
            expectedResult.AppendLine("42");
            expectedResult.AppendLine("1");
            expectedResult.AppendLine("31");
            expectedResult.AppendLine("15");
            expectedResult.AppendLine("20");
            expectedResult.AppendLine("13");
            expectedResult.AppendLine("55");
            expectedResult.AppendLine("1");
            expectedResult.AppendLine("22");
            expectedResult.AppendLine("17");
            expectedResult.AppendLine("50");
            expectedResult.AppendLine("1");
            expectedResult.AppendLine("54");
            expectedResult.AppendLine("1");
            expectedResult.AppendLine("40");
            expectedResult.AppendLine("33");
            expectedResult.AppendLine("26");
            expectedResult.AppendLine("1");
            expectedResult.AppendLine("76");
            expectedResult.AppendLine("8");
            expectedResult.AppendLine("43");
            expectedResult.AppendLine("21");
            expectedResult.AppendLine("46");
            expectedResult.AppendLine("1");
            expectedResult.AppendLine("66");
            expectedResult.AppendLine("17");
            expectedResult.AppendLine("64");
            expectedResult.AppendLine("23");
            expectedResult.AppendLine("32");
            expectedResult.AppendLine("1");
            expectedResult.AppendLine("108");
            expectedResult.AppendLine("1");
            expectedResult.AppendLine("34");
            expectedResult.AppendLine("41");
            expectedResult.AppendLine("63");
            expectedResult.AppendLine("19");
            expectedResult.AppendLine("78");
            expectedResult.AppendLine("1");
            expectedResult.AppendLine("58");
            expectedResult.AppendLine("27");
            expectedResult.AppendLine("74");
            expectedResult.AppendLine("1");
            expectedResult.AppendLine("123");
            expectedResult.AppendLine("1");
            expectedResult.AppendLine("40");
            expectedResult.AppendLine("49");
            expectedResult.AppendLine("64");
            expectedResult.AppendLine("19");
            expectedResult.AppendLine("90");
            expectedResult.AppendLine("1");
            expectedResult.AppendLine("106");
            expectedResult.AppendLine("40");
            expectedResult.AppendLine("44");
            expectedResult.AppendLine("1");
            expectedResult.AppendLine("140");
            expectedResult.AppendLine("23");
            expectedResult.AppendLine("46");
            expectedResult.AppendLine("33");
            expectedResult.AppendLine("92");
            expectedResult.AppendLine("1");
            expectedResult.AppendLine("144");
            expectedResult.AppendLine("21");
            expectedResult.AppendLine("76");
            expectedResult.AppendLine("35");
            expectedResult.AppendLine("50");
            expectedResult.AppendLine("25");
            expectedResult.AppendLine("156");
            expectedResult.AppendLine("1");
            expectedResult.AppendLine("73");
            expectedResult.AppendLine("57");
            expectedResult.AppendLine("117");
            expectedResult.AppendLine("8");
            expectedResult.AppendLine("1");
            expectedResult.AppendLine("16");
            expectedResult.AppendLine("1");
            expectedResult.AppendLine("10");
            expectedResult.AppendLine("9");
            expectedResult.AppendLine("15");
            expectedResult.AppendLine("1");
            expectedResult.AppendLine("21");
            expectedResult.AppendLine("1");

            return expectedResult.ToString();
        }

        private static string InputTestData()
        {
            var inputTestData = new StringBuilder();

            inputTestData.AppendLine("110");
            inputTestData.AppendLine("1");
            inputTestData.AppendLine("2");
            inputTestData.AppendLine("3");
            inputTestData.AppendLine("4");
            inputTestData.AppendLine("5");
            inputTestData.AppendLine("6");
            inputTestData.AppendLine("7");
            inputTestData.AppendLine("8");
            inputTestData.AppendLine("9");
            inputTestData.AppendLine("10");
            inputTestData.AppendLine("11");
            inputTestData.AppendLine("12");
            inputTestData.AppendLine("13");
            inputTestData.AppendLine("14");
            inputTestData.AppendLine("15");
            inputTestData.AppendLine("16");
            inputTestData.AppendLine("17");
            inputTestData.AppendLine("18");
            inputTestData.AppendLine("19");
            inputTestData.AppendLine("20");
            inputTestData.AppendLine("21");
            inputTestData.AppendLine("22");
            inputTestData.AppendLine("23");
            inputTestData.AppendLine("24");
            inputTestData.AppendLine("25");
            inputTestData.AppendLine("26");
            inputTestData.AppendLine("27");
            inputTestData.AppendLine("28");
            inputTestData.AppendLine("29");
            inputTestData.AppendLine("30");
            inputTestData.AppendLine("31");
            inputTestData.AppendLine("32");
            inputTestData.AppendLine("33");
            inputTestData.AppendLine("34");
            inputTestData.AppendLine("35");
            inputTestData.AppendLine("36");
            inputTestData.AppendLine("37");
            inputTestData.AppendLine("38");
            inputTestData.AppendLine("39");
            inputTestData.AppendLine("40");
            inputTestData.AppendLine("41");
            inputTestData.AppendLine("42");
            inputTestData.AppendLine("43");
            inputTestData.AppendLine("44");
            inputTestData.AppendLine("45");
            inputTestData.AppendLine("46");
            inputTestData.AppendLine("47");
            inputTestData.AppendLine("48");
            inputTestData.AppendLine("49");
            inputTestData.AppendLine("50");
            inputTestData.AppendLine("51");
            inputTestData.AppendLine("52");
            inputTestData.AppendLine("53");
            inputTestData.AppendLine("54");
            inputTestData.AppendLine("55");
            inputTestData.AppendLine("56");
            inputTestData.AppendLine("57");
            inputTestData.AppendLine("58");
            inputTestData.AppendLine("59");
            inputTestData.AppendLine("60");
            inputTestData.AppendLine("61");
            inputTestData.AppendLine("62");
            inputTestData.AppendLine("63");
            inputTestData.AppendLine("64");
            inputTestData.AppendLine("65");
            inputTestData.AppendLine("66");
            inputTestData.AppendLine("67");
            inputTestData.AppendLine("68");
            inputTestData.AppendLine("69");
            inputTestData.AppendLine("70");
            inputTestData.AppendLine("71");
            inputTestData.AppendLine("72");
            inputTestData.AppendLine("73");
            inputTestData.AppendLine("74");
            inputTestData.AppendLine("75");
            inputTestData.AppendLine("76");
            inputTestData.AppendLine("77");
            inputTestData.AppendLine("78");
            inputTestData.AppendLine("79");
            inputTestData.AppendLine("80");
            inputTestData.AppendLine("81");
            inputTestData.AppendLine("82");
            inputTestData.AppendLine("83");
            inputTestData.AppendLine("84");
            inputTestData.AppendLine("85");
            inputTestData.AppendLine("86");
            inputTestData.AppendLine("87");
            inputTestData.AppendLine("88");
            inputTestData.AppendLine("89");
            inputTestData.AppendLine("90");
            inputTestData.AppendLine("91");
            inputTestData.AppendLine("92");
            inputTestData.AppendLine("93");
            inputTestData.AppendLine("94");
            inputTestData.AppendLine("95");
            inputTestData.AppendLine("96");
            inputTestData.AppendLine("97");
            inputTestData.AppendLine("98");
            inputTestData.AppendLine("99");
            inputTestData.AppendLine("100");
            inputTestData.AppendLine("10");
            inputTestData.AppendLine("11");
            inputTestData.AppendLine("12");
            inputTestData.AppendLine("13");
            inputTestData.AppendLine("14");
            inputTestData.AppendLine("15");
            inputTestData.AppendLine("16");
            inputTestData.AppendLine("17");
            inputTestData.AppendLine("18");
            inputTestData.AppendLine("19");

            return inputTestData.ToString();
        }
    }
}