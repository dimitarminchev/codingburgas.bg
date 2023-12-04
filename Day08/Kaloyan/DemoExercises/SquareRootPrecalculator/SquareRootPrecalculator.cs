using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareRootPrecalculator
{
    public static class SquareRootPrecalculator
    {
        public const int MaxValue = 1000;

        private static double[] SqrtValues;

        static SquareRootPrecalculator() 
        {
            SqrtValues = new double[MaxValue+1];
            for (int i = 0; i < MaxValue; i++) 
            {
                SqrtValues[i] = Math.Sqrt(i);
            }
        }

        public static double GetSqrt(int x) 
        {
            return SqrtValues[x];
        }
    }
}
