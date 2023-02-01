using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_16.EF.Models
{
    public class PetShop
    {

        //PROPERTIES
        public string Name { get; set; }
        public List<PetFood>? Foods { get; set; }
        public List<Pet>? Pets { get; set; }
        public List<Employees>? Employees { get; set; }
        public List<Customers>? Customers { get; set; }
        public List<Transactions>? Transactions { get; set; }
        //public List<MonthlyLedger>? MonthlyLedgers { get; set; }
        private DateTime _openingDate { get; set; } = new DateTime(2022, 1, 1);




        //CTOR
        public PetShop()
        {
            Transactions = new List<Transactions>();
            Foods = new List<PetFood>();
            Pets = new List<Pet>();
            Employees = new List<Employees>();
            Customers = new List<Customers>();
        }

        public PetShop(string name, List<PetFood> foods, List<Pet>? pets, List<Employees>? employees, List<Customers>? customers, List<Transactions> transactions)
        {
            Name = name;

            Foods = foods;
            Pets = pets;
            Employees = employees;
            Customers = customers;
            Transactions = transactions;
            //FindMonthlyLedger(Transactions, Foods, Pets, Employees);
        }





        public List<PetFood> GetPetFood()
        {

            decimal currentStock = 0;
            foreach (var food in Foods)
            {
                food.CurrentStock = currentStock + food.Qty;
                foreach (var transaction in Transactions)
                {
                    var foodID = transaction.PetFoodID;
                    if (food.PetFoodID == foodID)
                    {
                        currentStock -= transaction.PetFoodQty;
                    }
                }
            }
            return Foods;
        }


        //METHOD DELETE FUNCTION
        public void DeleteTransaction(Transactions input)
        { //or guid??

            foreach (var trans in Transactions)
            {
                if (trans.TransID == input.TransID)
                {
                    if (trans.PetID == Guid.Empty)
                        //EnablePet(trans.PetID);  //set disable pet??????????
                        UpdatePetFoodQty(trans.PetFoodID, trans.PetFoodQty);
                    Transactions.Remove(trans);
                    break;
                }

            }
        }

        public void UpdatePetFoodQty(Guid? input, decimal foodupdate)
        {
            foreach (var food in Foods)
            {
                if (food.PetFoodID == input)
                {
                    food.Qty += foodupdate;
                }
            }

        }

        //DELETE PET FOOD
        public void DeletePetFood(Guid? input)
        {
            foreach (var food in Foods)
            {
                if (food.PetFoodID == input)
                {
                    Foods.Remove(food);
                }
            }
        }

        //DELETE PET
        public void DeletePet(Guid? input)
        {
            foreach (var pet in Pets)
            {
                if (pet.PetID == input)
                {
                    Pets.Remove(pet);
                }
            }
        }

        //MONTHLY LEDGER
        public void FindMonthlyLedger(List<Transactions> transactions, List<PetFood> foods, List<Pet> pets, List<Employees> employees)
        {

            //
        }

        decimal CalcEmployeesSalary(List<Employees> employees)
        {
            decimal totalSalaries = 0;
            foreach (var employee in employees)
            {
                totalSalaries += employee.SalaryPerMonth;
            }
            return totalSalaries;
        }



    }
}
