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
            bool isNumber;

            do
            {
                var amountOfInputs = 0;
                var textFromInput = reader.ReadLine();
                isNumber = ValidateDataFromInput(textFromInput, ref amountOfInputs);
                if (isNumber) CalculateSumsDivisorForNumbers(amountOfInputs, reader, writer);
            } while (!isNumber);

            reader.Close();
            writer.Flush();
            writer.Close();
        }

        private static bool ValidateDataFromInput(string textFromInput,ref int number)
        {
            bool isNumber = int.TryParse(textFromInput, out number);
            return isNumber;
        }

        private static void CalculateSumsDivisorForNumbers(int amountOfInputs, TextReader reader, TextWriter writer)
        {
            for (int i = 0; i < amountOfInputs; i++)
            {
                var textFromInput = reader.ReadLine();
                int number;
                int.TryParse(textFromInput, out number);
                if (number < MinRange || number > MaxRange) continue;
                writer.WriteLine(CalculateSumOfDivisorsForNumber(number));
            }
        }

        private static int CalculateSumOfDivisorsForNumber(int number)
        {
            int sum = 0;
            
            for (int divider = 1; divider < number; divider++)
            {
                if (number % divider == 0)
                {
                    sum += divider;
                }
            }

            return sum;
        }
    }
}
