using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class ExcFive
    {
        public void TimeConversions()
        {
            int seconds = 45678;
            decimal years, days, hours, minutes;

            years = (decimal)seconds / (decimal)(3600 * 24 * 365);
            years = Decimal.Round(years, 6);
            days = (decimal)seconds / (decimal)(3600 * 24);
            days = Decimal.Round(days, 6);
            hours = (decimal)seconds / 3600m;
            hours = Decimal.Round(hours, 6);
            minutes = (decimal)seconds / 60m;

            Console.WriteLine("The given number of seconds ( " + seconds + " ) equals " + minutes + " minutes");
            Console.WriteLine("The given number of seconds ( " + seconds + " ) equals " + hours + " hours");
            Console.WriteLine("The given number of seconds ( " + seconds + " ) equals " + days + " days");
            Console.WriteLine("The given number of seconds ( " + seconds + " ) equals " + years + " years\n\n");






        }


    }
}

