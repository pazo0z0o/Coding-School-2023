using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLib
{
    internal class RaiseToPower
    {

        public double Add(double? x, double? y)
        {

            double ret = 0;

            if (x != null && y != null)
            {
                ret = Math.Pow((double)x.Value, (double)y.Value);
            }

            return ret;
        }
    }
}
