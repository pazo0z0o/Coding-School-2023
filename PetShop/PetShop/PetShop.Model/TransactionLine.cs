using PetShop.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Model
{
   public class TransactionLine
    { // HAVE TO IMPLEMENT IT IN EF CONFIGURATIONS
        public int Id { get; set; }
        
        public int Quantity { get; set; }
        //petfood columns
        public PetFoodQuality PetFoodQuality { get; set; }
        public AnimalType AnimalType { get; set; }
        public decimal PetFoodPrice { get; set; }
        //pet columns
        public string PetBreed { get; set; }
        public decimal PetPrice { get; set; }

        public decimal TotalValue { get; set; }



        //Relationships with Transaction(1-M), PetFood(1-M),Pet(1-1)
        public int TransactionId { get; set; }
        public Transaction Transaction { get; set; } = null!;

        public int PetId { get; set; }
        public Pet Pet { get; set; } = null!; //TODO: might present a problem in the future 

        public int PetFoodId { get; set; }
        public PetFood PetFood { get; set; } = null!; 
    }
}
