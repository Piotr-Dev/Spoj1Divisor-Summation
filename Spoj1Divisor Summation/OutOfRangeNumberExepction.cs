using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Spoj1Divisor_Summation
{
    [Serializable]
    public class OutOfRangeNumberExepction : Exception
    {
        public int Number { get; set; }
        public override string Message { get; }

        public OutOfRangeNumberExepction(int number)
        {
            Number = number;
            Message = "Number is out of range \nNumber: " + Number;
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
        }
    }
}
