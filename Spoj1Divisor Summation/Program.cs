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
            var firstInputInteger = 0;
            var textFromInput = reader.ReadLine();

           ValidateDataFromInput(textFromInput, ref firstInputInteger);
           CalculateSumsDivisorForNumbers(firstInputInteger, reader, writer);
          
            reader.Close();
            writer.Flush();
            writer.Close();
        }

        private static void ValidateDataFromInput(string textFromInput,ref int number)
        {
            var isNotNumber = !TryParseStringToNumber(textFromInput,ref number);
            if(isNotNumber) throw new ArgumentException($"Input value: {textFromInput} is not a number or not in range: {MinRange}-{MaxRange}");

        }

        private static bool TryParseStringToNumber(string textFromInput, ref int number)
        {
            var isNumber = int.TryParse(textFromInput, out number);
            if (isNumber)
            {
                var inRange = number >= MinRange && number <= MaxRange;
                if (inRange) return true;
            }

            return false;
        }

        private static void CalculateSumsDivisorForNumbers(int amountOfNumbers, TextReader reader, TextWriter writer)
        {
            for (int i = 0; i < amountOfNumbers; i++)
            {
                var textFromInput = reader.ReadLine();
                var number = 0;
                ValidateDataFromInput(textFromInput, ref number);
                writer.WriteLine(CalculateSumOfDivisorsForNumber(number));
            }
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
