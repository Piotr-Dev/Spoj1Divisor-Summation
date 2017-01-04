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
            //Inform
            var myWriter = new StreamWriter(Console.OpenStandardOutput());
            myWriter.WriteLine("Inputs");
            myWriter.WriteLine("==============");
            myWriter.Flush();

            try
            {
                string resultString = reader.ReadLine();
                int length = Int32.Parse(resultString);
                for (int i = 0; i < length; i++)
                {
                    resultString = reader.ReadLine();
                    int number = Int32.Parse(resultString);
                    DoJob(number, writer);
                }

            }
            catch (MyNumberExepction e)
            {
                writer.WriteLine("Wrong range");
            }
            catch (ArgumentNullException e)
            {
                writer.WriteLine("Null exepction");
            }
            catch (OverflowException)
            {
                writer.WriteLine("Overflow exepction");
            }
            catch (FormatException)
            {
                writer.WriteLine("Not number");
            }
           

            finally
            {
                myWriter.WriteLine("\n");
                myWriter.WriteLine("Ouput");
                myWriter.WriteLine("==============");
                myWriter.Flush();
                myWriter.Close();

                reader.Close();
                writer.Flush();
                writer.Close();
            }
         
        }

        private static void DoJob(int number,TextWriter writer)
        { 
            if (number < 1 || number > 500000) throw new MyNumberExepction();

            int sum = 0;

            for (int i = 1; i < number; i++)
            {
                if ((number % i) == 0)
                {
                    sum += i;
                }
            }

            writer.WriteLine(sum);
        }
    }
}
