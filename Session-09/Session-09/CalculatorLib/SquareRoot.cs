using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLib
{
    public class SquareRoot : Operations
    {//have to implement it since I wanted to try and abstract
        public override decimal Op(decimal? x, decimal? y) { return 0; }
        public override decimal Op(decimal? x)
        {
            decimal ret = 0;

            if (x != null && x > 0)
            {
                ret = (decimal)Math.Sqrt((double)x.Value);
            }

            return ret;
        }

    }
}
