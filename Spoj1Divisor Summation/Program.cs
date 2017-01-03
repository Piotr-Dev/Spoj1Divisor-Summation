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
            List<int> result = new List<int>();

            try
            {
                string resultString = reader.ReadLine();
                int length = Int32.Parse(resultString);
                for (int i = 0; i < length; i++)
                {
                    resultString = reader.ReadLine();
                    int number = Int32.Parse(resultString);
                    result = DoJob(number, result);
                }

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
            catch (NullReferenceException)
            {
                writer.WriteLine("Null in !!!");
            }

            finally
            {
                reader.Close();
                writer.Flush();
                writer.Close();
            }
         
        }


        private static void WriteResults(TextWriter writer, List<int> result)
        {  
            foreach (var sum in result)
            {
                writer.WriteLine(sum.ToString());
            }
        }


        private static List<int> DoJob(int number,List<int> sumSet)
        { 
            if (number < 1 || number > 500000) throw new MyNumberExepction();

            int sum = 0;

            for (int i = 1; i <number; i++)
            {
                if ((number % i) == 0)
                {
                    sum += i;
                }
            }

            sumSet.Add(sum);
            return sumSet;
        }
    }
}
