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
                //var reader = new ReaderReader(Console.OpenStandardInput()); //new StreamReader(Console.OpenStandardInput());
                var reader = new StringReader(NumberInput());
                var writer = new StreamWriter(Console.OpenStandardOutput());
                writer.AutoFlush = false;

                Console.WriteLine(" \nOutput:");
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
            while (true) //do for every line of stream
            {
                List<int> divs = new List<int>();
                int number = Convert.ToInt32(reader.ReadLine());

                for (int i = 1; i < number; i++)
                {
                    if ((number % i) == 0)
                    {
                        divs.Add(i);
                    }

                }

                writer.WriteLine(divs.Sum());
                numberCount--;
                if (numberCount == 0)
                    break;

            }

            reader.Close();
            writer.Flush();
            writer.Close();
        }

        public static string NumberInput()
        {
            int inputNumber;
            var input = new StringBuilder();

            Console.WriteLine("Input:");
            inputNumber = Convert.ToInt32(Console.ReadLine()); //input number of test cases
            if (inputNumber < 0)
                throw new Exception("Incorrect input");

            input.AppendLine(inputNumber.ToString());
            int counter = inputNumber;

            for (int i = 0; i < counter; i++)
            {
                inputNumber = Convert.ToInt32(Console.ReadLine());
                if (inputNumber < 1 || inputNumber > 500000)
                    throw new Exception("Incorrect input (must be (1 <= n <= 500000))");
                input.AppendLine(inputNumber.ToString());
            }
            return input.ToString();
        }

    }
}
