using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class ExcThree
    {
        double result;
        public void Calculation1()
        {
      
            result = -1 + (5 * 6);
            Console.WriteLine("Result of 1st calculation: " + result);
        }
        public void Calculation2()
        { 
            result = (38 + (5%7));
            Console.WriteLine("Result of 2nd calculation: " + result);
        }
        public void Calculation3() 
        {
           
            result = (14 + ((-3 * 6) / 7));
            Console.WriteLine("Result of 3rd calculation: " + result);
        }

        public void Calculation4()
        {
            result = 2 + Math.Sqrt(7) + ((13/6)*6) ;
            Console.WriteLine("Result of 4th calculation: " + result);
        }

        public void Calculation5()
        {
            result = (Math.Pow(6,4)+ Math.Pow(5, 7))/ (9 % 4);
            Console.WriteLine("Result of 4th calculation: " + result);
        }



    }




    }

