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
        public static List<int> Inputs = new List<int>();
        public static List<int> Outputs = new List<int>();
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
            TakeInputs(reader);
            CalculateDividersSums();
            PrintOutputs(writer);

            reader.Close();
            writer.Flush();
            writer.Close();
        }
        private static void TakeInputs(TextReader reader)
        {
            var inputDataString = reader.ReadLine();
            var inputsNumber = int.Parse(inputDataString);

            for (int i = 0; i < inputsNumber; i++)
            {
                var liczba = int.Parse(reader.ReadLine());
                Inputs.Add(liczba);
            }
        }

        private static void CalculateDividersSums()
        {
            foreach (var number in Inputs)
            {
                int dividersSum = 0;
                if (number >= 1 && number <= 500000)
                {
                    for (int divider = 1; divider < number; divider++)
                    {
                        bool isDividable = number % divider == 0;
                        dividersSum += isDividable ? divider : 0;
                    }
                    Outputs.Add(dividersSum);
                }
            }
        }

        private static void PrintOutputs(TextWriter writer)
        {
            foreach (var number in Outputs)
            {
                writer.WriteLine(number);
            }
        }
    }
}
