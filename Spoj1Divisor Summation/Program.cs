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
                Console.WriteLine("Input:");
                var reader = new StringReader(NumberInput());

                Console.WriteLine(" \nOutput:");
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
            int numberCount = Convert.ToInt32(reader.ReadLine());

            for (int i = 0; i < numberCount; i++)
            {            
                int number = Convert.ToInt32(reader.ReadLine());
                List<int> divisors = CalculateDivisors(number);         
                writer.WriteLine(divisors.Sum());
            }

            reader.Close();
            writer.Flush();
            writer.Close();
        }

        private static List<int>CalculateDivisors(int number)
        {
            List<int> divisors = new List<int>();

            for (int i = 1; i < number; i++)
                if ((number % i) == 0) divisors.Add(i);

            return divisors;
        }


        public static string NumberInput()
        {
            int inputCount = Convert.ToInt32(Console.ReadLine());
            const int minInputCount = 1;

            if (inputCount <= minInputCount) throw new Exception("Incorrect input");

            var inputNumbers = new StringBuilder();
            inputNumbers.AppendLine(inputCount.ToString());

            for (int i = 0; i < inputCount; i++)
            {
                int number = Convert.ToInt32(Console.ReadLine());

                if (IsValidInputNumber(number)) throw new Exception("Incorrect input (must be (1 <= n <= 500000))");
                inputNumbers.AppendLine(number.ToString());
            }

            return inputNumbers.ToString();
        }

        private static bool IsValidInputNumber(int inputNumber)
        {
            const int lowerLimit = 1;
            const int upperLimit = 500000;

            if (inputNumber < lowerLimit) return false;
            if (inputNumber > upperLimit) return false;
            return true;
        }

    }
}
