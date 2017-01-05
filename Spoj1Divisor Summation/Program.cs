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
                int amountOfInputs;
                string textFromInput = reader.ReadLine();
                isNumber = int.TryParse(textFromInput, out amountOfInputs);
                if (isNumber) CalculateSumsDivisorForNumbers(amountOfInputs, reader, writer);
            } while (!isNumber);

            reader.Close();
            writer.Flush();
            writer.Close();
        }

        private static void CalculateSumsDivisorForNumbers(int amountOfInputs, TextReader reader, TextWriter writer)
        {
            for (int i = 0; i < amountOfInputs; i++)
            {
                string textFromInput = reader.ReadLine();
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
