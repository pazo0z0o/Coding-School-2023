using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_16.EF.Models
{
    public class Transactions
    {
        public Guid TransID { get; set; }
        public DateTime Date { get; set; }
        public Guid CustomerID { get; set; }
        public Guid EmployeeID { get; set; }
        public Guid PetID { get; set; }
        public decimal? PetPrice { get; set; }
        public Guid PetFoodID { get; set; }
        public decimal PetFoodQty { get; set; }
        public decimal? PetFoodPrice { get; set; }
        public decimal? TotalPrice { get; set; }
        public bool loaded = false;
        //=============Foreign Keys Emplo , Custom, Pet,PetFood  = ID 
        public Customers Customer { get; set; } = null!;
        public Employees Employee { get; set; } = null!;
        public Pet Pets { get; set; } = null!;
        public PetFood Pfood { get; set; } = null!;
        //==============================================================

        public Transactions()
        {
            TransID = Guid.NewGuid();
            Date = DateTime.Now;
            PetID = Guid.Empty;
        }


        //CTOR with pet

       /* public Transactions(DateTime date, Guid customerID, Guid employeeID, Guid petID, decimal petFoodQty, List<Pet> pets, List<PetFood> foods)
        {
            TransID = Guid.NewGuid();
            Date = date;
            CustomerID = customerID;
            EmployeeID = employeeID;
            PetFoodID = AddPetAndFood(petID, petFoodQty, foods, pets);

        }*/

        //Without pet
        /*public Transactions(DateTime date, Guid customerID, Guid employeeID, AnimalType animalType, decimal petFoodQty, List<PetFood> foods)
        {
            TransID = Guid.NewGuid();
            PetID = Guid.Empty;
            Date = date;
            CustomerID = customerID;
            EmployeeID = employeeID;
            PetFoodID = AddPetFood(animalType, petFoodQty, foods);
        }
*/

        //METHODS

        //addPet
       /* public Guid AddPetAndFood(Guid id, decimal petFoodQty, List<PetFood> foods, List<Pet> pets)
        {
            AnimalType foodType;
            foreach (Pet pet in pets)
            {
                if (pet.PetID == id)
                {
                    PetID = pet.PetID;
                    PetPrice = pet.Price;
                    foodType = pet.Animaltype;
                    //pet.SetTransactionID(PetID);
                    AddPetFood(foodType, petFoodQty, foods);

                    PetFoodQty++;
                    break;
                }
            }

            return id;
        }*/


        //addFood 
        /*public Guid AddPetFood(AnimalType foodType, decimal petFoodQty, List<PetFood> foods)
        {
            Guid foodID = Guid.Empty;
            foreach (var food in foods)
            {
                if (foodType == food.Animaltype)
                {
                    PetFoodPrice = food.Price;

                    foodID = food.PetFoodID;
                    PetFoodQty = petFoodQty;
                    break;
                }
            }
            SetTotalPrice();
            return foodID;
        }*/

        //public void SetPetPrice











        //SetTotalPrice
        public void SetTotalPrice()
        {

            if (this.PetID != Guid.Empty)
            {
                this.TotalPrice = PetPrice + (PetFoodQty * PetFoodPrice);
            }
            else
            {
                this.TotalPrice = (PetFoodQty * PetFoodPrice);
            }
        }

        public decimal FindPetPrice(List<Pet> pets)
        {

            decimal price = 0;
            foreach (var pet in pets)
            {
                if (pet.PetID == PetID)
                {
                    price = pet.Price;
                    break;
                }
            }
            return price;
        }

        public decimal FindPetFoodPrice(List<PetFood> foods)
        {
            decimal price = 0;
            foreach (var food in foods)
            {
                if (food.PetFoodID == PetFoodID)
                {
                    price = food.Price;
                    break;
                }
            }
            return price;
        }








    }
}
