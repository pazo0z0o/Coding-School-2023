using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_16.EF.Models
{
    public  class MonthlyLedger
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public decimal? Income { get; set; }
        public decimal? Expenses { get; set; }
        public decimal? Total { get; set; }

        public MonthlyLedger(int year, int month)
        {
            Year = year;
            Month = month;
        }













    }
}
