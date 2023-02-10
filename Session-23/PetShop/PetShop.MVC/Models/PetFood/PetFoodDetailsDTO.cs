using PetShop.Model;
using PetShop.Model.Enums;

namespace PetShop.MVC.Models.PetFood
{
    public class PetFoodDetailsDTO
    {

        public int Id { get; set; }
        public AnimalType AnimalType { get; set; }
          public decimal Price { get; set; }
          public decimal Cost { get; set; }

        // Relations
        public List<Transaction> Transactions { get; set; }
    }
}
