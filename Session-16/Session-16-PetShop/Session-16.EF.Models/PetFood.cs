﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_16.EF.Models
{
    public class PetFood
    {
        public Guid PetFoodID { get; set; }
        public AnimalType Animaltype { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }
        public decimal? Qty { get; set; }
        public decimal? CurrentStock { get; set; }

        public List<Transactions> Transacts { get; set; } //= null;


        public PetFood()
        {
            Qty = 0;
            PetFoodID = Guid.NewGuid();
        }

        public PetFood(AnimalType type, decimal cost, decimal price)
        {
            Qty = 0;
            PetFoodID = Guid.NewGuid();
            Animaltype = type;
            Cost = cost;
            Price = price;
        }

        public void SetQty(){}
        
            
    }
}
