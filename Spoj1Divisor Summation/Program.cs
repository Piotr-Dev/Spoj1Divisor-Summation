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

            List<int> Inputy = new List<int>();
            int ileRekordów = int.Parse(reader.ReadLine());

            for (int i = 0; i < ileRekordów; i++)
            {
                int liczba = int.Parse(reader.ReadLine());
                Inputy.Add(liczba);
            }
            foreach (var k in Inputy)

            {
                int suma = 0;
                if (k >= 1 && k <= 500000)
                {
                    for (int i = 1; i < k; i++)
                    {
                        if (k != i)
                        {
                            int czyPodzielna = k % i;
                            if (czyPodzielna == 0)
                            {
                                suma += i;
                            }
                        }
                    }
                    writer.WriteLine(suma);
                }
            }
            reader.Close();
            writer.Flush();
            writer.Close();
        }
    }
}