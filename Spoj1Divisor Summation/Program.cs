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
            var informationWriter = new StreamWriter(Console.OpenStandardOutput());
            informationWriter.WriteLine("Inputs\n==============");
            informationWriter.Flush();

            try
            {
                string resultString = reader.ReadLine();
                int length = int.Parse(resultString);
                for (int i = 0; i < length; i++)
                {
                   resultString = reader.ReadLine();
                   int number = int.Parse(resultString);
                   writer.WriteLine(CountSumOfDivisors(number));
                }

            }
            catch (OutOfRangeNumberExepction e)
            {
                writer.WriteLine(e.Message);
            }
            catch (ArgumentNullException e)
            {
                writer.WriteLine(e.Message);
            }
            catch (OverflowException e)
            {
                writer.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                writer.WriteLine(e.Message);
            }
           

            finally
            {
                informationWriter.WriteLine("\nOuput\n==============");
                informationWriter.Flush();
                informationWriter.Close();

                reader.Close();
                writer.Flush();
                writer.Close();
            }
         
        }

        private static int CountSumOfDivisors(int number)
        { 
            if (number < 1 || number > 500000) throw new OutOfRangeNumberExepction(number);

            int sum = 0;

            for (int i = 1; i < number; i++)
            {
                if ((number % i) == 0)
                {
                    sum += i;
                }
            }

            return sum;
           
        }
    }
}
