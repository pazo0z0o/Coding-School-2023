using FuelStation.Model.Enums;
using FuelStation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuelStation.Web.Shared.ManagerOnlyDTOs;

namespace FuelStation.Web.Shared.ManagerStaffSharedDTOs
{
    public class TransactionListDTO
    {
        public int ID { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public decimal TotalValue { get; set; }
        public PaymentMethod PaymentMethod { get; set; }

        // Relations
        public int CustomerId { get; set; }
        public int EmployeeId { get; set; }

       // public CustomerListDTO Customer { get; set; } = new();
        //public EmployeeListDTO Employee { get; set; } = new();
        public List<TransactionLineListDTO>? TransactionLines { get; set; } = new();

    }
}
