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
                number = GetNumber(reader);
                result = DoJob(number).ToList();
                WriteResults(writer, result);
            }
            catch (MyNumberExepction e)
            {
                writer.WriteLine("Wrong range!");
            }
            catch (ArgumentNullException e)
            {
                writer.WriteLine("Null exepction");
            }
            catch (OverflowException)
            {
                writer.WriteLine("Stack overflow exepction");
            }
            catch (FormatException)
            {
                writer.WriteLine("Not number");
            }

            finally
            {
                reader.Close();
                writer.Flush();
                writer.Close();
                Console.ReadLine();
            }
         
        }

        private static int GetNumber(TextReader reader)
        {
            string result = reader.ReadLine();
            int number = 0;
            number = Int32.Parse(result);
       
            return number;
        }


        private static void WriteResults(TextWriter writer, List<int> result)
        {
            foreach (var count in result)
            {
                writer.WriteLine(count.ToString());
            }
        }


        private static HashSet<int> DoJob(int number)
        {
            if (number < 1 || number > 500000) throw new MyNumberExepction();
            HashSet<int> result = new HashSet<int>();

            int sum = 0;

            for (int i = 0; i < (int) Math.Sqrt(number); i++)
            {
                
                if ((i % number) == 0)
                {
                    sum += i;
                }
            }

            return result;
        }
    }
}
