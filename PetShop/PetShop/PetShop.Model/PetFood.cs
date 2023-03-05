using PetShop.Model.Enums;

namespace PetShop.Model
{
    public class PetFood
    {
        public PetFood(AnimalType animalType, decimal price, decimal cost, PetFoodQuality pfoodQual)
        {
            AnimalType = animalType;
            Price = price;
            Cost = cost;
            FoodQuality = pfoodQual;
            Transactions = new List<Transaction>();
        }

        public int Id { get; set; }
        public AnimalType AnimalType { get; set; }
        public PetFoodQuality FoodQuality { get; set; }

        public decimal Price { get; set; }
        public decimal Cost { get; set; }

        // Relations
        public List<Transaction> Transactions { get; set; }
    }
}
