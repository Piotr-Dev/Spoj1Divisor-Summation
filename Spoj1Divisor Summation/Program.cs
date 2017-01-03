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
            int a = Convert.ToInt32(reader.ReadLine());
            for (int i = 0; i < a; i++)
            {
                int input = Convert.ToInt32(reader.ReadLine());


                int x = 1;
                List<int> iList = new List<int>();

                while (x < input)
                {
                    int b = input % x;
                    if (b == 0)
                    {
                        // Console.WriteLine(x);
                        iList.Add(x);
                    }
                    x++;
                }
                int sum = iList.Sum();

                //  writer.WriteLine("Suma podzielnikow to:");
                writer.WriteLine(sum);
                //*******************************
                //* TODO: Implement method body *
                //*******************************
            }
                reader.Close();
                writer.Flush();
                writer.Close();

            }
        
    }
}
