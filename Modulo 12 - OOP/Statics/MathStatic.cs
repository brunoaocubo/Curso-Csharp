using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statics
{
    internal static class MathStatic
    {
        public static int taxe = 10;

        public static int Increase(int value)
        {
            return value + taxe;
        }

        public static int Decrease(int value)
        {
            return value - taxe;
        }
    }
}
