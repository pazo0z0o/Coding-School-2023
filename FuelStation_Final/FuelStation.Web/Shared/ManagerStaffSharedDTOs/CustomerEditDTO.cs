using FuelStation.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Web.Shared.ManagerStaffSharedDTOs
{
    public class CustomerEditDTO
    {
        public int ID { get; set; }
        [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "The Name field can only contain Latin letters ")]
        [Required]
        public string Name { get; set; }
        [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "The Surname field can only contain Latin letters ")]
        [Required]
        public string Surname { get; set; }
        public string? CardNumber { get; set; }
        //=======================================
        public string FullName { get { return string.Format("{0} {1}", Name, Surname); } }

        public List<Transaction> Transactions { get; set; } = new();
    }
}
