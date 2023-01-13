using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class ExcSix
    {

        public void DateTimeLib()
        {
            int seconds = 45678;
            TimeSpan conversion = new TimeSpan(0, 0, seconds);

            Console.WriteLine($"This time with the TimeSpan method, {seconds} seconds equal : {conversion.TotalMinutes} minutes, {conversion.TotalHours} hours,  {conversion.TotalDays} days, {(conversion.TotalDays / 365)} years\n");

        }


    }
}
