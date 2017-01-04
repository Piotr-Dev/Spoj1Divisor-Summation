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
            //*******************************
            //* TODO: Implement method body *
            //*******************************
            string inputNum, inputSize;
            int quantity, number;
            var total = 0;
            List<int> ListOfNumbers = new List<int>();
            inputSize = reader.ReadLine();
            int.TryParse(inputSize, out quantity);

            for (int k = 0; k < quantity; k++)
            {
                inputNum = reader.ReadLine();
                int.TryParse(inputNum, out number);
                for (var i = 1; i <= number; i++)
                {
                    if (number % i == 0 && i != number)
                    {
                        ListOfNumbers.Add(i);
                    }
                }
                foreach (var item in ListOfNumbers)
                {
                    total = 0;
                    total = ListOfNumbers.Sum();
                }
                ListOfNumbers.Clear();
                writer.WriteLine(total);
            }
            reader.Close();
            writer.Flush();
            writer.Close();

        }
    }
}

