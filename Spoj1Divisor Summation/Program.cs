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
        public static void Main()
        {
            try
            {
                var reader = new StreamReader(Console.OpenStandardInput());
                var writer = new StreamWriter(Console.OpenStandardOutput());
                writer.AutoFlush = false;
                
                DivisorSumation(reader, writer); 
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }

        public static void DivisorSumation(TextReader reader, TextWriter writer)
        {
            var inputCount = Convert.ToInt32(reader.ReadLine());
            ValidateInputNumber(inputCount);

            var sumOfDivisors = DivisorSumationCalculation(inputCount,reader);

            PrintResults(sumOfDivisors,writer);

            reader.Close();
            writer.Flush();
            writer.Close();
        }

        private static void ValidateInputNumber(int inputNumber)
        {
            const int lowerLimit = 1;
            const int upperLimit = 500000;

            if (inputNumber < lowerLimit) throw new Exception($"Incorrect input (must be greather than {lowerLimit})");
            if (inputNumber > upperLimit) throw new Exception($"Incorrect input (must be smaller than {upperLimit})");
        }

        private static IEnumerable<int> DivisorSumationCalculation(int numberCount,TextReader reader)
        {
            var divisorsSums = new List<int>();
            for (int i = 0; i < numberCount; i++)
            {
                var number = Convert.ToInt32(reader.ReadLine());
                divisorsSums.Add(CalculateDivisors(number).Sum());
            }
            return divisorsSums;
        }

        private static IEnumerable<int>CalculateDivisors(int number)
        {
            var divisors = new List<int>();

            for (int divisorCandidate = 1; divisorCandidate < number; divisorCandidate++)
            {
                bool isDivisor = ((number % divisorCandidate) == 0);
                if (isDivisor) divisors.Add(divisorCandidate);
            }

            return divisors;
        }

        private static void PrintResults(IEnumerable<int> divisorsSums, TextWriter writer)
        {
            foreach (var divisorsSum in divisorsSums)
            {
                writer.WriteLine(divisorsSum);
            }
            const int numericInputUpperRange = 50000;

            var isOutOfRange = input < numericInputLowerRange ||
                               input > numericInputUpperRange;

            if (isOutOfRange)
                throw new ArgumentOutOfRangeException($"Expected range is ({numericInputLowerRange} , {numericInputUpperRange}) ");
        }
    }
}
