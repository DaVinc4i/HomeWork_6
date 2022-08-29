using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_6

{
    class Func2
    {
        public static double Quardratic(double x)
        {
            return 3 * x * x;
        }
        public static double Linear(double x)
        {
            return 2 * x + 3;
        }
        public static double Squaring(double x)
        {
            return x * x;
        }
        public static double Cubing(double x)
        {
            return x * x * x;
        }
        public static double Sqrt(double x)
        {
            return Math.Sqrt(x);
        }
        public static double Sin(double x)
        {
            return Math.Sin(x);
        }
    }
}