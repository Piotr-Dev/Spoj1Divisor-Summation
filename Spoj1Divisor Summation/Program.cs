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
            List<int> numbers = new List<int>();
            HashSet<int> result = new HashSet<int>();
          
            try
            {
                GetNumbers(numbers,reader);
                
                foreach (var number in numbers)
                {
                    result = DoJob(number,result);
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

            finally
            {
                reader.Close();
                writer.Flush();
                writer.Close();
            }
         
        }

        private static void GetNumbers(List<int> numbers, TextReader reader)
        {
            string resultString = "";
            do
            {
                resultString = reader.ReadLine();
               
                if (resultString != null)
                {
                    int number = 0;
                    if (resultString.Length != 0)
                    {
                        number = Int32.Parse(resultString);
                        numbers.Add(number);
                    }
                    
                }

            } while (resultString != null);
        }

        private static void WriteResults(TextWriter writer, HashSet<int> result)
        {
            List<int> resultList = result.ToList();
            resultList.Sort();
            
            foreach (var sum in resultList)
            {
                writer.WriteLine(sum.ToString());
            }
        }


        private static HashSet<int> DoJob(int number,HashSet<int> sumSet)
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
