using FuelStation.Model;
using FuelStation.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Web.Shared.ManagerOnlyDTOs
{
    public class EmployeeEditDTO
    {
        public int ID { get; set; }
        [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "The Name field can only contain Latin letters ")]
        [Required]
        public string Name { get; set; }
        [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "The Surname field can only contain Latin letters ")]
        [Required]
        public string Surname { get; set; }

        public DateTime HireDateStart { get; set; }
        public DateTime? HireDateEnd { get; set; } //Can be allowed to be null/empty in forms
        [RegularExpression("^[0-9]*$", ErrorMessage = "The field can only contain numeric digits.")]
        [Required]
        public decimal SalaryPerMonth { get; set; }
        public EmployeeType EmployeeType { get; set; }
        //===============================================
        public string FullName { get { return string.Format("{0} {1}", Name, Surname); } }

        public List<Transaction> Transactions { get; set; } = new();
    }
}
