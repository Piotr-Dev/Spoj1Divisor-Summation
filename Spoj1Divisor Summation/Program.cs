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

                reader.Close();
                writer.Flush();
                writer.Close();
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
            DivisorSumationCalculation(inputCount,reader,writer);
        }

        private static void ValidateInputNumber(int inputNumber)
        {
            const int lowerLimit = 1;
            const int upperLimit = 500000;

            if (inputNumber < lowerLimit) throw new Exception("Incorrect input (must be greather than 1)");
            if (inputNumber > upperLimit) throw new Exception("Incorrect input (must be smaller than 500000))");
        }

        private static void DivisorSumationCalculation(int numberCount,TextReader reader, TextWriter writer)
        {
            for (int i = 0; i < numberCount; i++)
            {
                var number = Convert.ToInt32(reader.ReadLine());
                writer.WriteLine(CalculateDivisors(number).Sum());
            }
        }

        private static List<int>CalculateDivisors(int number)
        {
            var divisors = new List<int>();

            for (int divisorCandidate = 1; divisorCandidate < number; divisorCandidate++)
            {
                bool isDivisor = ((number % divisorCandidate) == 0);
                if (isDivisor) divisors.Add(divisorCandidate);
            }

            return divisors;
        }
    }
}
