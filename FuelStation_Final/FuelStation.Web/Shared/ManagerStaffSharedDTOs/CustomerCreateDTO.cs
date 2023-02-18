using FuelStation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Web.Shared.ManagerStaffSharedDTOs
{
    public class CustomerCreateDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string? CardNumber { get; set; }
        //=======================================
        public string FullName { get { return string.Format("{0} {1}", Name, Surname); } }

        public List<Transaction> Transactions { get; set; } = new();
    }
}
