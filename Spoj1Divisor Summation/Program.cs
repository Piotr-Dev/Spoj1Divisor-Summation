using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Spoj1Divisor_Summation
{
    public class Program
    {
        public static void Main()
        {
            var reader = new StreamReader(Console.OpenStandardInput());
            var writer = new StreamWriter(Console.OpenStandardOutput());
            writer.AutoFlush = false;

            DivisorSumation(reader, writer);
        }

        public static void DivisorSumation(TextReader reader, TextWriter writer)
        {
            GetDividerSums(reader)
                .ToList()
                .ForEach(sum => writer.WriteLine(sum));

            reader.Close();
            writer.Flush();
            writer.Close();
        }

        private static IEnumerable<int> GetDividerSums(TextReader reader)
        {
            var inputCount = GetInputedNumber(reader.ReadLine());

            for (int i = 0; i < inputCount; i++)
            {
                var inputNumber = GetInputedNumber(reader.ReadLine());

                var dividersSum = GetDividers(inputNumber).Sum();

                yield return dividersSum;
            }
        }

        private static IEnumerable<int> GetDividers(int inputNumber)
        {
            for (int divider = 1; divider < inputNumber; divider++)
            {
                var isTrueDivider = inputNumber % divider == 0;

                if (isTrueDivider)
                {
                    yield return divider;
                }
            }
        }

        private static int GetInputedNumber(string inputString)
        {
            var inputedNumber = int.Parse(inputString);

            ValidateNumericInput(inputedNumber);

            return inputedNumber;
        }

        private static void ValidateNumericInput(int input)
        {
            const int numericInputLowerRange = 0;
            const int numericInputUpperRange = 50000;

            var isOutOfRange = input < numericInputLowerRange ||
                               input > numericInputUpperRange;

            if (isOutOfRange)
                throw new ArgumentOutOfRangeException($"Expected range is ({numericInputLowerRange} , {numericInputUpperRange}) ");
        }
    }
}
