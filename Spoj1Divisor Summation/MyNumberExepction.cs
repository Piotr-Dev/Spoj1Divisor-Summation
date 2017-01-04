using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spoj1Divisor_Summation
{
    public class MyNumberExepction : Exception
    {
        public int Number { get; set; }
        public string Message { get; set; }

        public MyNumberExepction(int number, string message)
        {
            Number = number;
            Message = message;
        }
    }
}
