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

            var inputQuantity = GetInputedNumber(reader.ReadLine());

            for (var size = 0; size < inputQuantity; size++)
            {
                int inputedNumber = GetInputedNumber(reader.ReadLine());
                writer.WriteLine(GetSumOfProperDivisors(inputedNumber));
            }

            reader.Close();
            writer.Flush();
            writer.Close();
        }


        public static int GetInputedNumber(string number)
        {
            var inputedNumber = int.Parse(number);
            ValidateInputedNumbers(inputedNumber);
            return inputedNumber;
        }

        public static void ValidateInputedNumbers(int inputedNumber)
        {
            bool isValidRange = inputedNumber < MaxRange && inputedNumber >= MinRange;
            while (!isValidRange) throw new Exception($"Invalid input: Please enter a number between {MinRange} and {MaxRange}");
        }

        public static int GetSumOfProperDivisors(int inputedNumber)
        {
            var sum = 0;

            for (var divisor = 1; divisor < inputedNumber; divisor++)
            {
                var isProperDivisor = inputedNumber % divisor == 0;

                if (isProperDivisor)
                {
                    sum += divisor;
                }
            }
            return sum;

        }
    }
}



