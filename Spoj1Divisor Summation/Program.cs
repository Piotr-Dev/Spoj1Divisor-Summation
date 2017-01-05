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
            ObliczSumyPodzielników(reader, writer);
                reader.Close();
                writer.Flush();
                writer.Close();

        }
        public static void ObliczSumyPodzielników(TextReader reader, TextWriter writer)
        {
            int iloscLiczb = Convert.ToInt32(reader.ReadLine());
            for (int i = 0; i < iloscLiczb; i++)
            {
                DodaniePodzielnikow(reader, writer);
            }
        }
        public static void DodaniePodzielnikow(TextReader reader, TextWriter writer)
        {
            int liczba = Convert.ToInt32(reader.ReadLine());
            int podzielnik = 1;
            var SumaPodzielnikow = new List<int>();
            while (podzielnik < liczba)
            {
                int Reszta = liczba % podzielnik;
                if (Reszta == 0)
                {
                    SumaPodzielnikow.Add(podzielnik);
                }
                podzielnik++;
            }
            int Suma = SumaPodzielnikow.Sum();
            writer.WriteLine(Suma);
        }
        
    }
}
