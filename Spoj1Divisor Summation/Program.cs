using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        }
        public static void DivisorSumation(TextReader reader, TextWriter writer)
        {
            //*******************************
            //* TODO: Implement method body *
            //*******************************
            Console.WriteLine("Inputs");
            TakeInputs(reader);

            CalculateDividersSums();

            Console.WriteLine("\nOutputs:");
            for (int number = 0; number < Outputs.Count; number++)
            {
                writer.WriteLine(Outputs[number]);
            }

            reader.Close();
            writer.Flush();
            writer.Close();
        }
        private static void TakeInputs(TextReader reader)
        {
            bool isNumber = false;
            while (!isNumber)
            {
                string inputDataString = reader.ReadLine();
                int inputNumber = 0;
                isNumber = int.TryParse(inputDataString, out inputNumber);
                for (int i = 0; i < inputNumber; i++)
                {
                    int number = int.Parse(reader.ReadLine());
                    Inputs.Add(number);
                }
            }
        }

        private static void CalculateDividersSums()
        {
            for (int value = 0; value < Inputs.Count; value++)
            {
                int dividersSum = 0;
                if (Inputs[value] >= 1 && Inputs[value] <= 500000)
                {
                    for (int divider = 1; divider < Inputs[value]; divider++)
                    {
                        dividersSum += Inputs[value] % divider == 0 ? divider : 0;
                    }
                    Outputs.Add(dividersSum);
                }
            }
        }
    }
}
