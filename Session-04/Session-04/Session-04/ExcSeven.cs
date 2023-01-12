using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class ExcSeven
    {
        public void TenpConverter()
        {
            int celsius = 100;
            //kelvin = celsius + 273
            //fahrenheit = celsius x 18 / 10 + 32

            Console.WriteLine("100 degrees Celsius in different temperature units");
            Console.WriteLine("From Celsius to Kelvin : " + (celsius + 273));
            Console.WriteLine("From Celsius to Fahrenheit : " + (celsius * 18 / 10 + 32));

        }




    }
}
