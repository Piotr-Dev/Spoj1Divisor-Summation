using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spoj1Divisor_Summation
{
    public class Program
    {
        public const int MaxRange = 500000;
        public const int MinRange = 1;
        public static void Main()
        {
            var reader = new StreamReader(Console.OpenStandardInput());
            var writer = new StreamWriter(Console.OpenStandardOutput());
            writer.AutoFlush = false;


            DivisorSumation(reader, writer);
            Console.ReadKey();
        }

        public static void DivisorSumation(TextReader reader, TextWriter writer)
        {

            GetAllDivisorsSumation(reader, writer);
            reader.Close();
            writer.Flush();
            writer.Close();
        }

        public static void GetAllDivisorsSumation(TextReader reader, TextWriter writer)
        {
            var inputQuantity = GetNumber(reader.ReadLine());

            for (var size = 0; size < inputQuantity; size++)
            {
                int inputedNumber = GetNumber(reader.ReadLine());
                writer.WriteLine(GetSumOfProperDivisors(inputedNumber));
            }
        }

        public static int GetNumber(string inputedNumber)
        {
            var inputNumber = int.Parse(inputedNumber);
            ValidateInputedNumbers(inputNumber);
            return inputNumber;
        }

        public static void ValidateInputedNumbers(int inputedNumber)
        {
            bool isValidRange = inputedNumber < MaxRange && inputedNumber >= MinRange;
            while (!isValidRange) throw new Exception($"Invalid input: Please enter a number between {MinRange} and {MaxRange}");
        }

        public static int GetSumOfProperDivisors(int number)
        {
            var sum = 0;

            for (var divisor = 1; divisor < number; divisor++)
            {
                var isProperDivisor = number % divisor == 0;

                if (isProperDivisor)
                {
                    sum += divisor;
                }
            }
            return sum;

        }
    }
}



