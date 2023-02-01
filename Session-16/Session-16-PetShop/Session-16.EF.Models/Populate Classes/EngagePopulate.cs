using Session_16.EF.Models.Populate_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;


namespace Session_16.EF.Models
{
    public class EngagePopulate
    {

        public EngagePopulate() { }


        public PetShop SetPopulation()
        {

            PopulatePetFood populatePetFood = new PopulatePetFood();
            PopulatePet populatePet = new PopulatePet();
            PopulateEmployee populateEmployees = new PopulateEmployee();
            PopulateCustomer populateCustomer = new PopulateCustomer();
            PopulateTransaction populateTransaction = new PopulateTransaction();
            MonthlyLedger monthlyLedger = new MonthlyLedger();
            //PetShop petshop = new PetShop() {
            //    Name = "Mr Pet",
            //    Foods = populatePetFood.PopulatePetFoods(),
            //    Pets = populatePet.PopulatePets(),
            //    Employees = populateEmployees.PopulateEmployees(),
            //    Customers = populateCustomer.PopulateCustomers()

            //};

            string name = "Mr Pet";
            var foods = populatePetFood.PopulatePetFoods();
            var pets = populatePet.PopulatePets();
            var employees = populateEmployees.PopulateEmployees();
            var customers = populateCustomer.PopulateCustomers();
            var transactions = populateTransaction.PopulateTransactions(foods, pets, employees, customers);
           // SetBoughtDate(pets, transactions);

            PetShop petshop = new PetShop(name, foods, pets, employees, customers, transactions);



            //petshop.Transactions = populateTransaction.PopulateTransactions(petshop.Foods, petshop.Pets, petshop.Employees, petshop.Customers);
            //SetBoughtDate(petshop.Pets, petshop.Transactions);
            //petshop.FindMonthlyLedger(petshop.Transactions, petshop.Foods, petshop.Pets, petshop.Employees);
            //setSoldPets(petshop.Pets, petshop.Transactions);
            return petshop;
        }

        public void setSoldPets(List<Pet> pets, List<Transactions> transactions)
        { //sold pets

            foreach (var trans in transactions)
            {
                foreach (var pet in pets)
                {
                    if (pet.PetID == trans.PetID)
                    {
                        //pet.Sold = true;
                        break;
                    }
                }
            }
        }
        /*public void SetBoughtDate(List<Pet> pets, List<Transactions> transactions)
        {

            //pets in transaction
            foreach (var pet in pets)
            {
                foreach (var trans in transactions)
                {
                    if (pet.PetID == trans.PetID)
                    {
                        pet.Bought = RandomDate(trans.Date);
                        break;
                    }
                }
                DateTime dt = new DateTime(1990, 1, 1);

                if (pet.Bought == dt)
                {
                    DateTime today = DateTime.Now;
                    pet.Bought = RandomDate(today);
                }
            }

            //available pets
            foreach (var pet in pets)
            {
                if (pet.TransID == Guid.Empty)
                {
                    pet.Bought = RandomDate();
                }
            }

        }*/


        public DateTime RandomDate()
        {
            Random gen = new Random();
            DateTime start = new DateTime(2022, 1, 1);
            int range = ((TimeSpan)(DateTime.Now - start)).Days;
            return start.AddDays(gen.Next(range));
        }

        public DateTime RandomDate(DateTime datebought)
        {
            Random gen = new Random();
            DateTime start = new DateTime(2022, 1, 1);
            int range = ((TimeSpan)(datebought - start)).Days;
            return start.AddDays(gen.Next(range));
        }




    }
}

   

