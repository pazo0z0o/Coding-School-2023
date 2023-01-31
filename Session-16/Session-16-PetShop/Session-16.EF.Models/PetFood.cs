using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_16.EF.Models
{
   public class PetFood : Pet
   {
        public Guid PetFoodID { get; set; }
        //public AnimalType Animaltype { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }
        public decimal? Qty { get; set; }
        public decimal? CurrentStock { get; set; }

        public List<Transactions> Transacts { get; set; }


        public PetFood()
        {
            Qty = 0;
            PetFoodID = Guid.NewGuid();
        }



    }
}
