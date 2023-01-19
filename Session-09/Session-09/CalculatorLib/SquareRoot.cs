using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLib
{
    internal class SquareRoot
    {
        public decimal SqrRoot(decimal? x)
        {
            decimal ret = 0;

            if (x != null && x > 0 )
            {
                ret = (decimal)Math.Sqrt((double)x.Value);
            }

            return ret;
        }
    }
}
