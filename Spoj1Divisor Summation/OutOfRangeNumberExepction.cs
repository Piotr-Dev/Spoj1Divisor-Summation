using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spoj1Divisor_Summation
{
    public class OutOfRangeNumberExepction : Exception
    {
        public int Number { get; set; }
        public override string Message { get; }

        public OutOfRangeNumberExepction(int number)
        {
            Number = number;
            Message = "Number is out of range \nNumber: " + Number;
        }
    }
}
