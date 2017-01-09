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
        public static Dictionary<int, int> CalcualatedDivisors = new Dictionary<int, int>();
        public static void Main()
        {
            var reader = new StreamReader(Console.OpenStandardInput());
            var writer = new StreamWriter(Console.OpenStandardOutput());
            writer.AutoFlush = false;

            DivisorSumation(reader, writer);
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
            var firstInputDataString = reader.ReadLine();
            var inputsCount = int.Parse(firstInputDataString);

            for (int i = 0; i < inputsCount; i++)
            {
                {
                    var liczba = int.Parse(reader.ReadLine());
                    Inputs.Add(liczba);
                }
            }
        }

        private static void CalculateDividersSums()
        {
            var validInputs = Inputs.Where(ValidInput());
            foreach (var number in validInputs)
            {
                Outputs.Add(SumDividers(number));
            }
        }
        
        private static Func<int, bool> ValidInput()
        {
            int minInput = 1;
            int maxInput = 500000;
            return x => x >= minInput && x < maxInput;
        }

        public static int SumDividers(int number)
        {
            int dividersSum = 0;
            if (!CalcualatedDivisors.ContainsKey(number))
            {
                for (int divider = 1; divider < number; divider++)
                {
                    bool isDividable = number % divider == 0;
                    if (isDividable)
                    {
                        dividersSum += divider;
                    }
                }
                CalcualatedDivisors.Add(number, dividersSum);
            }
            else
            {
                dividersSum = CalcualatedDivisors[number];
            }

            return dividersSum;
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

