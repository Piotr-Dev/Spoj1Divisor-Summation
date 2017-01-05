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
            var reader = new StreamReader(Console.OpenStandardInput());
            var writer = new StreamWriter(Console.OpenStandardOutput());
            writer.AutoFlush = false;


            DivisorSumation(reader, writer);
            Console.ReadKey();
        }

        public static void DivisorSumation(TextReader reader, TextWriter writer)
        {
            int number = 0, quantity = 0;
            const int maxRange = 500000, minRange = 1;
            var inputString = new StreamWriter(Console.OpenStandardOutput());
            var outputString = new StreamWriter(Console.OpenStandardOutput());
            inputString.WriteLine("Input:");
            inputString.Flush();
            bool validQuantity = int.TryParse(reader.ReadLine(), out quantity);
            while (!validQuantity)
            {
                inputString.WriteLine("Please enter a valid number.");
                inputString.Flush();
                validQuantity = int.TryParse(reader.ReadLine(), out quantity);
            }
            for (int size = 0; size < quantity; size++)
            {
                bool validNumber = int.TryParse(reader.ReadLine(), out number) && number < maxRange && number > minRange;
                while (!validNumber)
                {
                    inputString.WriteLine("Please enter a number between 1 and 500000.");
                    inputString.Flush();
                    validNumber = int.TryParse(reader.ReadLine(), out number) && number < maxRange && number > minRange;
                }
                writer.WriteLine(GetTotalSumOfProperDivisors(number));
            }

            outputString.WriteLine("Output:");
            outputString.Flush();
            reader.Close();
            writer.Flush();
            writer.Close();
        }
        public static int GetTotalSumOfProperDivisors(int number)
        {
            int sum = 0, total = 0;
            
            for (int divisor = 1; divisor < number; divisor++)
            {
                if (number % divisor == 0)
                {
                    total += sum + divisor;
                }
            }
            return total;
        }
    }
}



