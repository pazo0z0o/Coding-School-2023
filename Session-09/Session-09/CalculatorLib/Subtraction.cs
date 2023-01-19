using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLib
{
    internal class Subtraction
    {
        public decimal Subtract(decimal? x, decimal? y)
        {
            decimal ret = 0;
            if (x != null && y != null)
            {
                ret = x.Value - y.Value;
            }
            return ret;
        }



    }
}
