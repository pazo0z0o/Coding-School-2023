﻿using FuelStation.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Model
{
   public class Item
    {
       public int ID { get; set; } 
       public string Code { get; set; }
       public string Description { get; set; }
       public ItemType ItemType { get; set; }
        public decimal Price { get; set; }
       public decimal Cost { get; set; }
        //==========================
        public Item() { }

        //Relationships
        public List<TransactionLine> TransactionLines { get; set; }

    }
}
