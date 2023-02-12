using PetShop.Model;

namespace PetShop.MVC.Models.Customer
{
    public class CustomerCreateDTO
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Phone { get; set; }
        public string? Tin { get; set; }

       // public List<Transaction> Transactions { get; set; } = new List<Transaction>();
       
    }
}
