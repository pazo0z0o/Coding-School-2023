using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class ExcSeven
    {
        //kelvin = celsius + 273
        //fahrenheit = celsius x 18 / 10 + 32

        Console.WriteLine(""); 
        int celsius = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Kelvin = {0}", celsius + 273);
        Console.WriteLine("Fahrenheit = {0}", celsius* 18 / 10 + 32);


    }
}
