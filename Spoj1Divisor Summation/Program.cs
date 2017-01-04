﻿using System;
using System.IO;


namespace Spoj1Divisor_Summation
{
    public class Program
    {
        private const int MinRange = 1;
        private const int MaxRange = 500000;

        public static void Main()
        {
            var reader = new StreamReader(Console.OpenStandardInput());
            var writer = new StreamWriter(Console.OpenStandardOutput());
            writer.AutoFlush = false;

            DivisorSumation(reader, writer);
        }

        public static void DivisorSumation(TextReader reader, TextWriter writer)
        {
            WriteInformationAboutData("Input");

            int amountOfInputs = 0;
            bool isNotNumber = false;
            do
            {
                string textFromInput = reader.ReadLine();
                isNotNumber = !int.TryParse(textFromInput, out amountOfInputs) ? true : CalculateSumsDivisorForNumbers(amountOfInputs, reader, writer);
            } while (isNotNumber);

            WriteInformationAboutData("Output");

            reader.Close();
            writer.Flush();
            writer.Close();
        }

        private static bool CalculateSumsDivisorForNumbers(int amountOfInputs, TextReader reader, TextWriter writer)
        {
            string textFromInput = string.Empty;
            int number = 0;

            for (int i = 0; i < amountOfInputs; i++)
            {
                textFromInput = reader.ReadLine();
                int.TryParse(textFromInput, out number);
                if (number < MinRange || number > MaxRange) continue;
                writer.WriteLine(CalculateSumOfDivisorsForNumber(number));
            }

            return false;
        }

        private static void WriteInformationAboutData(string information)
        {
            var informationWriter = new StreamWriter(Console.OpenStandardOutput());
            informationWriter.WriteLine(information + "\n==============");
            informationWriter.Flush();
            informationWriter.Close();
        }

        private static int CalculateSumOfDivisorsForNumber(int number)
        {
            int sum = 0;
            
            for (int divider = 1; divider < number; divider++)
            {
                if (number % divider == 0)
                {
                    sum += divider;
                }
            }

            return sum;
        }
    }
}
