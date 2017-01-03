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
            List<int> result = DoJob(number).ToList();
            reader.Close();
            writer.Flush();
            writer.Close();
        }

        private static HashSet<int> DoJob(int number)
        {
            if (number < 1 && number > 500000) throw new MyNumberExepction();
            HashSet<int> result = new HashSet<int>();

            return result;
        }
    }
}
