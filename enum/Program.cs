using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @enum
{
    class Program
    {
        enum operation
        {
            sum,
            minus,
            multiplication,
            divide,
            pow,
            sqrt
        }
        static int DoOperation(operation op, int a, int b)
        {
            switch(op)
            {
                case operation.sum: return a + b;
                case operation.minus: return a - b;
                case operation.multiplication: return a * b;
                case operation.divide: return a / b;
                case operation.pow: return Convert.ToInt32(Math.Pow(a, b)); ;
                case operation.sqrt: return Convert.ToInt32(Math.Sqrt(a));
                default: return 0;
            }
         
        }

        static void Main(string[] args)
        {
            DoOperation(operation.divide, 3, 3);
        }
    }
}
