using PetShop.Model.Enums;

namespace PetShop.Model
{
    public class PetFood
    {
        public PetFood(AnimalType animalType, decimal price, decimal cost )
        {
            AnimalType = animalType;
            Price = price;
            Cost = cost;
            
            TransactionLines = new List<TransactionLine>();
        }

        public int Id { get; set; }
        public AnimalType AnimalType { get; set; }
        public PetFoodQuality PetFoodQuality { get; set; }

        public decimal Price { get; set; }
        public decimal Cost { get; set; }

        // Relations
        public Stock Stock { get; set; } // 1-1 relationship
       // public List<Transaction> Transactions { get; set; }

        public List<TransactionLine> TransactionLines { get; set; } = new List<TransactionLine>();
    }
}
