using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLib
{
    internal class SquareRoot
    {
        public decimal SqrRoot(decimal? x, decimal? y)
        {
            decimal ret = 0;

            if (x != null && y != null)
            {
                ret = (decimal)Math.Pow((double)x.Value,(double)(y.Value));
            }

            return ret;
        }
    }
}
