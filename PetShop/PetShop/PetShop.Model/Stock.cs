using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetShop.Model.Enums;
using PetShop.Model;

namespace PetShop.Model
{
    public class Stock
    {
        //also have a blazor column that calculates the percentage of use
        public int Remaining { get; set; }
        public int Overall { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }


    }
}
