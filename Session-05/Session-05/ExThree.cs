using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class ExThree
    {
        public void FindPrimes()
        {
            int res=0, flag ;
            int i;
            Console.WriteLine("Give me an integer, and I will find its primes : ");
           
            int num = Convert.ToInt32(Console.ReadLine());

            for (i = 2; i <= num; i++)
            {
                flag = 0;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                      flag++;  
                      break;
                    }                    
                }
                
                if (flag == 0 ) 
                {  
                    res = i;
                   Console.Write(" "+ res+" ");                
                }
                
            //κατέληξα να την κάνω void+Console.Write επειδή είχα θέμα με τα return και τα for που δεν είχα προβλέψει.
                
            }
            Console.WriteLine(Environment.NewLine);
        }
    
    }
}
