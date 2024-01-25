using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalcLib
{

    [Serializable]
    public class MyCalcDivideOnZeroException : Exception
    {
        public MyCalcDivideOnZeroException() { }
        public MyCalcDivideOnZeroException(string message) : base(message) { }
        public MyCalcDivideOnZeroException(string message, Exception inner) : base(message, inner) { }
        protected MyCalcDivideOnZeroException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }

    public class MyCalc
    {
        public static double Sum(double a, double b)
        {
            return a + b ;
        }

        public static double Divide(double a, double b)
        {
            
            if (b == 0)
                throw new MyCalcDivideOnZeroException();

            return a / b;
        }
    }
}
