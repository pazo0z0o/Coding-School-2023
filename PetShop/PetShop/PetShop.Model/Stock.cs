using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetShop.Model.Enums;
using PetShop.Model;

namespace PetShop.Model
{
    public class Stock
    {   

        public int Id { get; set; }

        public int StockQuantity { get; set; }
       
        public int Month { get; set; }
        public int Year { get; set; }

        public AnimalType AnimalType { get; set; }
        public PetFoodQuality PetFoodQuality { get; set; }
        
        //Relation
        public int StockFoodId { get; set; }
        public  PetFood PetFoods { get; set; } = null!;
        //ctor

       public Stock()
        {

        }
        public Stock(int quantity, AnimalType animalType,PetFoodQuality petFoodQuality)
        {
            StockQuantity = quantity;
            AnimalType= animalType;
            PetFoodQuality= petFoodQuality;
        }

    }
}
