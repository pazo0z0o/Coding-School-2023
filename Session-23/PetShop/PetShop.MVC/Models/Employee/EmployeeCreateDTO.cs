using PetShop.Model;
using PetShop.Model.Enums;

namespace PetShop.MVC.Models.Employee
{
    public class EmployeeCreateDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public EmployeeType EmployeeType { get; set; }
        public int SalaryPerMonth { get; set; }

        // Relations
        public List<Transaction> Transactions { get; set; }
    }
}
