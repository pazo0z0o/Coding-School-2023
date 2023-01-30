using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_16.EF.Models
{
    [PrimaryKey(nameof(Year), nameof(Month))]
    public class PetReport
    {   //This is very very dubious with year and month
        public int Year { get; set; }
        public int Month { get; set; }
        public AnimalType Animal { get; set; }

        public decimal TotalSold { get; set; }

        public PetReport() { }
       

        public PetReport(int year, int month)
        {
            Year = year ;
            Month = month ;
        }

    }
}
