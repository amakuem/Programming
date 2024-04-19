using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2.Services
{
    public static class ClassForTask2
    {
        public static double Calculate(double c, double d, double k, double z)
        {
            double result, x;
            if (z < 0)
            {
                x = Math.Pow(z, 2) - z;
            }
            else
            {
                x = Math.Pow(z, 3);
            }
            result = Math.Sin(c * x + Math.Pow(d, 2) + k * Math.Pow(x, 2));
            return result;
        }
    }
}
