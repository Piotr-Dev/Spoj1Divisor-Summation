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
        }

        public static void DivisorSumation(TextReader reader, TextWriter writer)
        {
           //*******************************
           //* TODO: Implement method body *
           //*******************************
            int number = 0;

            List<int> result = new List<int>();

            try
            {
                result = DoJob(number).ToList();
                WriteResults(writer, result);
            }
            catch (MyNumberExepction e)
            {
                writer.WriteLine("Wrong range!");
            }

            finally
            {
                reader.Close();
                writer.Flush();
                writer.Close();
                Console.ReadLine();
            }
         
        }

        private static void WriteResults(TextWriter writer, List<int> result)
        {
            throw new NotImplementedException();
        }


        private static HashSet<int> DoJob(int number)
        {
            if (number < 1 || number > 500000) throw new MyNumberExepction();
            HashSet<int> result = new HashSet<int>();

            for (int i = 0; i < (int) Math.Sqrt(number); i++)
            {
                if ((i % number) == 0)
                {
                    result.Add(i);
                }
            }

            return result;
        }
    }
}
