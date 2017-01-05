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
            Console.ReadLine();
        }
        public static void DivisorSumation(TextReader reader, TextWriter writer)
        {
            LiczbaPowtorzenObliczen(reader, writer);
                reader.Close();
                writer.Flush();
                writer.Close();

        }
        public static void LiczbaPowtorzenObliczen(TextReader reader, TextWriter writer)
        {
            int IloscLiczb = Convert.ToInt32(reader.ReadLine());
            for (int i = 0; i < IloscLiczb; i++)
            {
                DodaniePodzielnikow(reader, writer);
            }
        }
        public static void DodaniePodzielnikow(TextReader reader, TextWriter writer)
        {
            int input = Convert.ToInt32(reader.ReadLine());
            int Podzielnik = 1;
            List<int> SumaPodzielnikow = new List<int>();
            while (Podzielnik < input)
            {
                int b = input % Podzielnik;
                if (b == 0)
                {
                    SumaPodzielnikow.Add(Podzielnik);
                }
                Podzielnik++;
            }
            int sum = SumaPodzielnikow.Sum();
            writer.WriteLine(sum);
        }
        
    }
}
