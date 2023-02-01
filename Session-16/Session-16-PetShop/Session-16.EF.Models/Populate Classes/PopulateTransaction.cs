using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_16.EF.Models.Populate_Classes
{
    public class PopulateTransaction
    {

        public PopulateTransaction()
        {

        }

        public List<Transactions> PopulateTransactions(List<PetFood> foods, List<Pet> pets, List<Employees> employees, List<Customers> customers)
        {

            List<Transactions> transactions = new List<Transactions>();
            Transactions tr;
            int petIndex = 0;
            int customerIndex = 0;
            var random = new Random();

            //with pet populate


            while (petIndex < 5)
            {
                tr = new Transactions(RandomDate(), customers[customerIndex].CustomerID, employees[random.Next(employees.Count)].EmployeeID, pets[petIndex].PetID, RandomQty(), pets, foods);
                transactions.Add(tr);
                customerIndex++;
                petIndex++;
            }
            //only pet food
            while (customerIndex < customers.Count)
            {
                tr = new Transactions(RandomDate(), customers[customerIndex].CustomerID, employees[random.Next(employees.Count)].EmployeeID, GetRandomType(), RandomQty(), foods);
                transactions.Add(tr);
                customerIndex++;
            }
            tr = new Transactions(RandomDate(), customers[0].CustomerID, employees[0].EmployeeID, GetRandomType(), RandomQty(), foods);
            transactions.Add(tr);
            return transactions;
        }


        public Transactions SetPetAndFood(Transactions tr, List<Pet> pets, List<PetFood> foods, int petIndex)
        {
            var newPet = pets[petIndex];
            if (tr.PetID != Guid.Empty)
            {
                foreach (var food in foods)
                {
                    if (food.Animaltype == newPet.Animaltype)
                    {
                        tr.PetFoodID = food.PetFoodID;
                        break;
                    }
                }
            }
            else
            {
                tr.PetFoodID = RandomPetFood(foods);
            }
            return tr;
        }



        public int RandomEmployee(List<Employees> employees)
        {
            var random = new Random();
            int employee = random.Next(1, employees.Count);
            return employee;
        }

        public int RandomQty()
        {
            var random = new Random();
            int qty = random.Next(1, 20);
            return qty;
        }

        public Guid RandomPetFood(List<PetFood> foods)
        {
            var random = new Random();
            var pf = foods[random.Next(0, foods.Count)].PetFoodID;
            return pf;
        }

        public DateTime RandomDate()
        {
            Random gen = new Random();
            DateTime start = new DateTime(2022, 1, 1);
            int range = ((TimeSpan)(DateTime.Today - start)).Days;
            return start.AddDays(gen.Next(range));
        }

        public AnimalType GetRandomType()
        {
            Array values = Enum.GetValues(typeof(AnimalType));
            Random random = new Random();
            AnimalType randomType = (AnimalType)values.GetValue(random.Next(values.Length));
            return randomType;
        }
    }
}
