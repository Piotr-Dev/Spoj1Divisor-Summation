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
        public const int maxRange = 500000, minRange = 1;
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

            ValidateInput(reader, writer);
            reader.Close();
            writer.Flush();
            writer.Close();
        }
        public static void ValidateInput(TextReader reader, TextWriter writer)
        {
            int quantity;
            bool validateQuantity = int.TryParse(reader.ReadLine(), out quantity);

            while (!validateQuantity)
            {
                validateQuantity = int.TryParse(reader.ReadLine(), out quantity);
            }

            for (var size = 0; size < quantity; size++)
            {
                ValidateInputNumbers(reader, writer);
            }
        }
        public static void ValidateInputNumbers(TextReader reader, TextWriter writer)
        {
            int number;
            bool validateNumber = int.TryParse(reader.ReadLine(), out number) && number < maxRange && number >= minRange;

            while (!validateNumber)
            {
                validateNumber = int.TryParse(reader.ReadLine(), out number) && number < maxRange && number >= minRange;
            }
            writer.WriteLine(GetSumOfProperDivisors(number));
        }

        public static int GetSumOfProperDivisors(int number)
        {
            var total = 0;

            for (var divisor = 1; divisor < number; divisor++)
            {
                if (number % divisor == 0)
                {
                    total += divisor;
                }
            }
            return total;

        }
    }
}



