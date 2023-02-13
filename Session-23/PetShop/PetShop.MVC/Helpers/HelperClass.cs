using PetShop.EF.Repositories;
using PetShop.Model;

namespace PetShop.MVC.Helpers
{
    public class HelperClass
    {
        private readonly IEntityRepo<Customer> _customerRepo;
        private readonly IEntityRepo<Employee> _employeeRepo;
        private readonly IEntityRepo<Pet> _petRepo;
        private readonly IEntityRepo<PetFood> _petFoodRepo;
        private readonly IEntityRepo<Transaction> _transactionRepo;

        //List<HelperClass> MonthlyLedger 

        public HelperClass(IEntityRepo<Customer> customerRepo, IEntityRepo<Employee> employeeRepo, IEntityRepo<Pet> petRepo, IEntityRepo<PetFood> petFoodRepo, IEntityRepo<Transaction> transactionRepo)
        {
            _customerRepo = customerRepo;
            _employeeRepo = employeeRepo;
            _petRepo = petRepo;
            _petFoodRepo = petFoodRepo;
            _transactionRepo = transactionRepo;
        }

        public List<decimal> MonthIncome(IEntityRepo<Pet> petRepo, IEntityRepo<PetFood> petFoodRepo, IEntityRepo<Transaction> transactionRepo)
        {
            var pets = _petRepo.GetAll().ToList();
            var petFood = _petFoodRepo.GetAll().ToList();
            var transactions = _transactionRepo.GetAll().ToList();

            decimal monthlyInc = 0;
            List<decimal> IncomePerMonth  = new List<decimal>();

            var orderedTrans = transactions.OrderBy(m => m.Date.Month).ToList();

            for (int i = 1; i < 13; i++)
            {

                var monthly = orderedTrans.DistinctBy(m => m.Date.Month == i).ToList();

                //Monthly Income
                foreach (var totalInc in monthly)
                {
                    monthlyInc += totalInc.TotalPrice;
                
                }

               IncomePerMonth.Add(monthlyInc);    

            }
            return IncomePerMonth;
        
        }

        public List<decimal> MonthlyExpenses(IEntityRepo<Pet> petRepo, IEntityRepo<PetFood> petFoodRepo, IEntityRepo<Transaction> transactionRepo)
        {
            var pets = _petRepo.GetAll().ToList();
            var petFood = _petFoodRepo.GetAll().ToList();
            var transactions = _transactionRepo.GetAll().ToList();

            decimal monthlyExp = 0;
            List<decimal> ExpensesPerMonth = new List<decimal>();

            //key column will have the pet's Id and value column will have the Cost
            Dictionary<int, decimal> PetCost = new Dictionary<int, decimal>();
            foreach (var pet in pets)
            {
                PetCost.Add(pet.Id, pet.Cost);
            }
            //============================================ Loop Start ==========================================================================
            var orderedTrans = transactions.OrderBy(m => m.Date.Month).ToList();

            for (int i = 1; i < 13; i++)
            {
                var monthly = orderedTrans.DistinctBy(m => m.Date.Month == i).ToList();

                //Monthly Expense
                decimal cleanPetFoodCost = 0;
                foreach (var pFood in monthly)
                {
                    if (pFood.PetPrice != 0) // alternate check for pet being bought
                    {
                        cleanPetFoodCost += pFood.PetFoodPrice * (pFood.PetFoodQty - 1);
                    }
                    else
                        cleanPetFoodCost += pFood.PetFoodPrice * pFood.PetFoodQty;
                }
                //Monthly Expense
                decimal monthlyPetCost = 0;
                foreach (var pet in transactions)
                {
                    if (PetCost.ContainsKey(pet.PetId))
                    {
                        monthlyPetCost += PetCost[pet.PetId];
                    }
                }
                decimal standardExp = StableExpences();
                monthlyExp = monthlyPetCost + standardExp + cleanPetFoodCost;

                ExpensesPerMonth.Add(monthlyExp);
            }

            return ExpensesPerMonth;
        }

        public decimal StableExpences()
        {
            decimal standardExpense = 0;
            decimal rent = 2000;

            var employees = _employeeRepo.GetAll().ToList();

            foreach (var employee in employees)
            {
                standardExpense += employee.SalaryPerMonth;
            }

            standardExpense += rent;
            return standardExpense;
        }











    }
}
