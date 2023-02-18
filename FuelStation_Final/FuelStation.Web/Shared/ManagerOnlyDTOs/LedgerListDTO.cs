using FuelStation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Web.Shared.ManagerOnlyDTOs
{
    public class LedgerListDTO
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public decimal Income { get; set; }
        public decimal Expenses { get; set; }
        public decimal Total { get; set; }


        // Relations
        public List<TransactionListDTO> Transactions { get; set; }
        //public List<Employee> Employees { get; set; }
        //public List<Customer> Customers  { get; set; }
    }
}
