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
            Console.ReadKey();
        }
        public static void DivisorSumation(TextReader reader, TextWriter writer)
        {
            //*******************************
            //* TODO: Implement method body *
            //*******************************
            Console.WriteLine("Inputs");
            List<int> Inputy = new List<int>();
            int ileRekordów = 0;
            // int ileRekordów = int.Parse(reader.ReadLine());
            while (ileRekordów == 0)
            {
                try
                {
                    ileRekordów = int.Parse(reader.ReadLine());
                }
                catch (FormatException e)
                {
                    ileRekordów = 0;
                }
                catch (ArgumentNullException e)
                {
                    ileRekordów = 0;
                }
                catch (OverflowException e)
                {
                    ileRekordów = 0;
                }
            }

            for (int i = 0; i < ileRekordów; i++)
            {
                try
                {
                    int liczba = int.Parse(reader.ReadLine());
                    Inputy.Add(liczba);
                }
                catch (FormatException e)
                {
                }
                catch (ArgumentNullException e)
                {
                }
                catch (OverflowException e)
                {
                }
            }
            Console.WriteLine("\nOutputs");
            foreach (var k in Inputy)
            {
                int suma = 0;
                if (k >= 1 && k <= 500000)
                {               
                    for (int i = 1; i < k; i++)
                    {                      
                            int czyPodzielna = k % i;
                            if (czyPodzielna == 0)
                            {
                                suma += i;
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