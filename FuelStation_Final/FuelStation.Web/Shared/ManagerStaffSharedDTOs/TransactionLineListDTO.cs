using FuelStation.Model;
using FuelStation.Web.Shared.ItemDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Web.Shared.ManagerStaffSharedDTOs
{
    public class TransactionLineListDTO
    {
        public int ID { get; set; }
        public int Quantity { get; set; }
        public decimal ItemPrice { get; set; }
        public decimal NetValue { get; set; }  // value after discounts and cost
        public decimal DiscountPercent { get; set; }
        public decimal DiscountValue { get; set; }
        public decimal TotalValue { get; set; }

        //Relations
        public int TransactionId { get; set; }
        public TransactionListDTO Transaction { get; set; } = null!;

        public int ItemID { get; set; }
        public ItemListDTO Item { get; set; } = null!;
        //===============================
       
    }
}
