using FuelStation.Model.Enums;
using FuelStation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Web.Shared.ItemDTOs
{
    public class ItemCreateDTO
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public ItemType ItemType { get; set; }
        public ItemType ItemTypeNoFuel { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }
        //==========================

        //Relationships
        public List<TransactionLine> TransactionLines { get; set; } = new();
    }
}
