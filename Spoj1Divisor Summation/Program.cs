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
            string inputNumber, inputSize;
            int number = 0;
            int quantity = 0;
            var inputString = new StreamWriter(Console.OpenStandardOutput());
            var outputString = new StreamWriter(Console.OpenStandardOutput());
            inputString.WriteLine("Input:");
            inputString.Flush();
            inputSize = reader.ReadLine();
            int.TryParse(inputSize, out quantity);
            for (int k = 0; k < quantity; k++)
            {
                inputNumber = reader.ReadLine();
                int.TryParse(inputNumber, out number);
                writer.WriteLine(CalculateDivisorsSumation(number));
            }
            //outputString.WriteLine("Output:");


            outputString.Flush();
            reader.Close();
            writer.Flush();
            writer.Close();  
        }

        public static void ConverseToInt()
        {

        }
        public static int CalculateDivisorsSumation(int number)
        {
            List<int> ListOfNumbers = new List<int>();
            int total= 0;
            
            for (int divisor = 1; divisor < number; divisor++)
            {
                if (number % divisor == 0)
                {
                    ListOfNumbers.Add(divisor);
                }
            }

            foreach(var item in ListOfNumbers)
            {
                total = 0;
                total = ListOfNumbers.Sum();

            }
            ListOfNumbers.Clear();
            return total;
        }
    }
}


//if (string.IsNullOrWhiteSpace(inputNum)) throw new ArgumentNullException("test");
//mininumber //maximumnumber

