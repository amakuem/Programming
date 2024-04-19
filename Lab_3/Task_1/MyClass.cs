using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public static class MyClass
    {
        public static double Calculate(double a,  double b)
        {
            if((a - Math.Sin(a)) < (b - Math.Sin(b)))
            {
                return a;
            }
            else
            {
                return b;
            }
        }
    }
}
