using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLib
{
    public class Multiplication : Operations
    {
        //have to implement cause of abstract class base
        public override decimal Op(decimal? x) { return 0; }
        public override decimal Op(decimal? x, decimal? y)
        {
            decimal ret = 0;

            if (x != null && y != null)
            {
                ret = x.Value * y.Value;
            }
            return ret;
        }
    }
}
