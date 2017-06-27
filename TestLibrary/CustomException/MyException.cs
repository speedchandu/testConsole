using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary.CustomException
{
    public class MyExceptionExample
    {
        public static double Divide(int a, int b)
        {
            if (b==5)
            {
                throw new Divideby5Exception("Cannot Divide by 5.");
            }
            else if(b==0)
            {
                throw new DivideByZeroException();
            }
            else
            {
                return a / b;
            }
        }
    }


    [Serializable]
    public class Divideby5Exception : Exception
    {
        
        public Divideby5Exception():base("Cannot divide by 5.") {
            
        }
        public Divideby5Exception(string message) : base(message) { }
        public Divideby5Exception(string message, Exception inner) : base(message, inner) { }
        protected Divideby5Exception(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
