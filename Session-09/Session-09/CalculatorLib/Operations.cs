using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using CalculatorLib;

namespace CalculatorLib
{
    public abstract class Operations
    {   //let's try today's subject
        public abstract decimal Op(decimal? a);
        public abstract decimal Op(decimal? x, decimal? y);
    }
}

public class Addition : Operations
{   //have to implement cause of abstract class base
    public override decimal Op(decimal? x) { return 0; }
    public override decimal Op(decimal? x, decimal? y)
    {
        decimal ret = 0;
        if (x != null && y != null)
        {
            ret = x.Value + y.Value;
        }
        return ret;
    }
}

public class Subtraction : Operations
{
    //have to implement cause of abstract class base
    public override decimal Op(decimal? x) { return 0; }
    public override decimal Op(decimal? x, decimal? y)
      {
        decimal ret = 0;
        if (x != null && y != null)
        {
            ret = x.Value - y.Value;
        }
        return ret;
      }
}

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

public class Division : Operations
{   //have to implement cause of abstract class base
    public override decimal Op(decimal? x) { return 0; }
    public override decimal Op(decimal? x, decimal? y)
    {
        decimal ret = 0;

        if (x != null && y != null)
        {
            ret = x.Value / y.Value;
        }

        return ret;
    }
}

public class RaiseToPower : Operations
{   //have to implement cause of abstract class base
    public override decimal Op(decimal? x) { return 0; }
    public override decimal Op(decimal? x, decimal? y)
    {
        decimal ret = 0;

        if (x != null && y != null)
        {
            ret = (decimal)Math.Pow((double)x.Value, (double)y.Value);
        }

        return ret;
    }
}


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