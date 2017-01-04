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
        public static List<int> Inputy = new List<int>();
        public static List<int> Outputy = new List<int>();
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
            TakeInputs(reader);
            GiveOutputs();
            Console.WriteLine("\nOutputs:");
            foreach (var dana in Outputy)
            {
                writer.WriteLine(dana);
            }
            reader.Close();
            writer.Flush();
            writer.Close();
        }
        public static void TakeInputs(TextReader reader)
        {
            var ileRekordów = 0;
            while (ileRekordów == 0)
            {
                try
                {
                    ileRekordów = int.Parse(reader.ReadLine());
                }
                catch (FormatException)
                {
                    ileRekordów = 0;
                }
                catch (ArgumentNullException)
                {
                    ileRekordów = 0;
                }
                catch (OverflowException)
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
                catch (FormatException)
                {
                }
                catch (ArgumentNullException)
                {
                }
                catch (OverflowException)
                {
                }
            }
        }
        private static void GiveOutputs()
        {
            foreach (var liczba in Inputy)
            {
                int suma = 0;
                int pierwiastek = (int)Math.Sqrt(liczba);
                if (liczba >= 1 && liczba <= 500000)
                {
                    for (int i = 1; i < pierwiastek; ++i)
                    {
                        bool czyPodzielna = liczba % i == 0;
                        if (czyPodzielna)
                        {
                            suma += i + pierwiastek / i;
                        }
                        if (i == pierwiastek)
                        {
                            suma += i;
                        }
                    }
                    suma -= pierwiastek;
                    Outputy.Add(suma);
                }
            }
        }
    }
}