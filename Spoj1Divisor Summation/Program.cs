using System;
using System.IO;


namespace Spoj1Divisor_Summation
{
    public class Program
    {
        private const int MinRange = 1;
        private const int MaxRange = 500000;

        public static void Main()
        {
            var reader = new StreamReader(Console.OpenStandardInput());
            var writer = new StreamWriter(Console.OpenStandardOutput());
            writer.AutoFlush = false;

            DivisorSumation(reader, writer);
        }

        public static void DivisorSumation(TextReader reader, TextWriter writer)
        {
            var inputString = reader.ReadLine();

            var inputCount = GetNumberFromInputString(inputString);

            for (int i = 0; i < inputCount; i++)
            {
                inputString = reader.ReadLine();
                var number = GetNumberFromInputString(inputString);
                writer.WriteLine(CalculateSumOfDivisorsForNumber(number));
            }

            reader.Close();
            writer.Flush();
            writer.Close();
        }

        private static int GetNumberFromInputString(string inputString)
        {
            var number = int.Parse(inputString);
            ValidateDataFromInput(number);      
            return number;
        }

        private static void ValidateDataFromInput(int number)
        {
            var isNotInRange = number < MinRange || number > MaxRange;
            if (isNotInRange) throw new ArgumentOutOfRangeException("number", $"Input {number} not in range: {MinRange}-{MaxRange}");
        }

        private static int CalculateSumOfDivisorsForNumber(int number)
        {
            var sum = 0;
            
            for (var divider = 1; divider < number; divider++)
            {
                var isDivisable = number % divider == 0;
                
                if (isDivisable)
                {
                    sum += divider;
                }
            }

            return sum;
        }
    }
}
