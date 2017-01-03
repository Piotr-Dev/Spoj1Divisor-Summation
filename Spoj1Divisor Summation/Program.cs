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
            string inputNum;
            string inputSize;
            var total = 0;
            List<int> list = new List<int>();
            inputSize = reader.ReadLine();
            var z = Convert.ToInt32(inputSize);
            for (int k = 0; k < z; k++)
            {
                inputNum = reader.ReadLine();
                var number = Convert.ToInt32(inputNum);
                for (var i = 1; i <= number; i++)
                {
                    if (number % i == 0 && i != number)
                    {
                        list.Add(i);

                    }
                }
                foreach (var item in list)
                {

                    total = 0;
                    total = list.Sum();

                }
                list.Clear();
                writer.WriteLine(total);
            }
            reader.Close();
            writer.Flush();
            writer.Close();

        }
    }
}

