using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using Newtonsoft.Json.Linq;
using PetShop.EF.Repositories;
using PetShop.Model;
using PetShop.Model.Enums;
using PetShop.MVC.Models.Customer;
using PetShop.MVC.Models.Transactions;
using System.Data.Common;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;

namespace PetShop.MVC.Controllers
{
    public class TransactionController : Controller
    {   //all the repos in the land
        private readonly IEntityRepo<Customer> _customerRepo;
        private readonly IEntityRepo<Employee> _employeeRepo;
        private readonly IEntityRepo<Pet> _petRepo;
        private readonly IEntityRepo<PetFood> _petFoodRepo;
        private readonly IEntityRepo<Transaction> _transactionRepo;

        public TransactionController(IEntityRepo<Customer> customerRepo, IEntityRepo<Employee> employeeRepo, IEntityRepo<Pet> petRepo, IEntityRepo<PetFood> petFoodRepo, IEntityRepo<Transaction> transactionRepo)
        {
            _customerRepo = customerRepo;
            _employeeRepo = employeeRepo;
            _petRepo = petRepo;
            _petFoodRepo = petFoodRepo;
            _transactionRepo = transactionRepo;
        }

        // GET: Transaction
        public ActionResult Index()
        {
            var transactions = _transactionRepo.GetAll().ToList();
            return View(model: transactions);
        }

        // GET: Transaction/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null) { return NotFound(); }

            var transaction = _transactionRepo.GetById(id);
            if (transaction == null) { return NotFound(); }

            var viewTransaction = new DetailsTransactionsDTO()
            {
                Date = transaction.Date,
                CustomerId = transaction.CustomerId,
                Customers = transaction.Customer,
                EmployeeId = transaction.EmployeeId,
                Employees = transaction.Employee,
                PetId = transaction.PetId,
                PetPrice = transaction.PetPrice,
                PetFoodId = transaction.PetFoodId,
                PetFoodPrice = transaction.PetFoodPrice,
                PetFoodQty = transaction.PetFoodQty,


                TotalPrice = transaction.TotalPrice
            };

            return View(model: viewTransaction);
            //return View();
        }

        // GET: Transaction/Create
        public ActionResult Create()
        {

            var viewTransaction = new CreateTransactionsDTO();

            var customers = _customerRepo.GetAll();
            var employees = _employeeRepo.GetAll();
            var pets = _petRepo.GetAll();
            var petfoods = _petFoodRepo.GetAll();

            //Select 
            foreach (var cus in customers)
            {
                viewTransaction.Customer.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(cus.Surname + " " + cus.Name, cus.Id.ToString()));
            }

            foreach (var emp in employees)
            {
                viewTransaction.Employee.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(emp.Surname + " " + emp.Name, emp.Id.ToString()));
            }

            foreach (var pet in pets)
            {
                string AT = Enum.GetName(typeof(AnimalType), pet.AnimalType);
                string ptStr = AT + pet.Breed + "-" + pet.Price.ToString();
                viewTransaction.Pet.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(ptStr, pet.Id.ToString()));
            }

            foreach (var pfood in petfoods)
            {
                string AT = Enum.GetName(typeof(AnimalType), pfood.AnimalType);
                string pfStr = AT + "-" + pfood.Price.ToString();

                viewTransaction.PetFood.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(pfStr, pfood.Id.ToString()));
            }

            return View(viewTransaction);
        }

        // POST: Transaction/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateTransactionsDTO trans)
        {

            if (!ModelState.IsValid) return View();

            var dbTransact = new Transaction(trans.PetPrice, trans.PetFoodQty, trans.PetFoodPrice, trans.TotalPrice)
            {

                Date = DateTime.Now,
                CustomerId = trans.CustomerId,
                EmployeeId = trans.EmployeeId,
                PetId = trans.PetId,
                PetFoodId = trans.PetFoodId
            };
            // Some calculations about the free pet food 

            dbTransact.TotalPrice = CalcTotal(dbTransact.PetId, dbTransact.PetPrice, dbTransact.PetFoodPrice, dbTransact.PetFoodQty);

            _transactionRepo.Add(dbTransact);
            return RedirectToAction("Index");
        }

        // GET: Transaction/Edit/5
        public ActionResult Edit(int id)
        {
            //string ptPrice = string.Empty;
            // string pfPrice = string.Empty;

            var customers = _customerRepo.GetAll();
            var employees = _employeeRepo.GetAll();
            var pets = _petRepo.GetAll();
            var petfoods = _petFoodRepo.GetAll();

            if (id == null) { return NotFound(); }

            var dbTransact = _transactionRepo.GetById(id);
            if (dbTransact == null) return NotFound();

            var viewTransaction = new EditTransactionsDTO()
            {
                Date = dbTransact.Date,
                PetFoodQty = dbTransact.PetFoodQty,
                TotalPrice = dbTransact.TotalPrice,
                CustomerId = dbTransact.CustomerId,
                EmployeeId = dbTransact.EmployeeId,
                PetId = dbTransact.PetId,
                PetFoodId = dbTransact.PetFoodId
            };

            foreach (var cus in customers)
            {
                viewTransaction.Customer.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(cus.Surname + " " + cus.Name, cus.Id.ToString()));
            }

            foreach (var emp in employees)
            {
                viewTransaction.Employee.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(emp.Surname + " " + emp.Name, emp.Id.ToString()));
            }

            foreach (var pet in pets)
            {
                string AT = Enum.GetName(typeof(AnimalType), pet.AnimalType);
                string ptStr = AT + pet.Breed + "-" + pet.Price.ToString();
                viewTransaction.Pet.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(ptStr, pet.Id.ToString()));
            }
            //  viewTransaction.PetPrice = GetPricePet(ptPrice);
            foreach (var petfood in petfoods)
            {
                string AT = Enum.GetName(typeof(AnimalType), petfood.AnimalType);
                string pfStr = AT + "-" + petfood.Price.ToString();
                viewTransaction.PetFood.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(pfStr, petfood.Id.ToString()));
            }
            // viewTransaction.PetFoodPrice = GetPricePetFood(pfPrice);

            return View(viewTransaction);
        }

        // POST: Transaction/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, EditTransactionsDTO edTrans)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var dbTransact = _transactionRepo.GetById(id);
            if (dbTransact == null) return NotFound();

            dbTransact.Date = edTrans.Date;
            dbTransact.CustomerId = edTrans.CustomerId;
            dbTransact.EmployeeId = edTrans.EmployeeId;
            dbTransact.PetId = edTrans.PetId;
            dbTransact.PetPrice = edTrans.PetPrice;
            dbTransact.PetFoodId = edTrans.PetFoodId;
            dbTransact.PetFoodPrice = edTrans.PetFoodPrice;
            dbTransact.PetFoodQty = edTrans.PetFoodQty;

            dbTransact.TotalPrice = CalcTotal(dbTransact.PetId, dbTransact.PetPrice, dbTransact.PetFoodPrice, dbTransact.PetFoodQty);

            _transactionRepo.Update(id, dbTransact);
            return RedirectToAction(nameof(Index));
        }

        // GET: Transaction/Delete/5
        public ActionResult Delete(int id)
        {
            var dbTransaction = _transactionRepo.GetById(id);
            if (dbTransaction == null) return NotFound();

            var viewTrans = new DeleteTransactionsDTO()
            {
                Id = dbTransaction.Id,
                Date = dbTransaction.Date,
                CustomerId = dbTransaction.CustomerId,
                EmployeeId = dbTransaction.EmployeeId,
                PetId = dbTransaction.PetId,
                PetPrice = dbTransaction.PetPrice,
                PetFoodId = dbTransaction.PetFoodId,
                PetFoodPrice = dbTransaction.PetFoodPrice,
                TotalPrice = dbTransaction.PetPrice
            };

            return View(model: viewTrans);
        }

        // POST: Transaction/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            _transactionRepo.Delete(id);
            return RedirectToAction(nameof(Index));
        }
        //========================= Some Helping Methods for field manipulation ============================    

        public decimal CalcTotal(int petId, decimal petPrice, decimal pfoodPrice, int pfoodQty)
        {
            decimal Total = 0;

            if (petId != null)
            {
                if (pfoodQty == 1)
                {
                    Total = petPrice + pfoodPrice * pfoodQty;
                }
                else
                {
                    Total = petPrice + pfoodPrice * (pfoodQty - 1);
                }
            }
            else
            {
                Total = pfoodPrice * pfoodQty;
            }

            return Total;
        }

        //tried this Idea, didn't work, I'll try and figure it out on my own time

        public decimal GetPricePet(string comboStr)
        {
            decimal price = 0;
            char[] seperator = { '-' };
            int count = 3;

            String[] strlist = comboStr.Split(seperator, count, StringSplitOptions.None);
            price = Convert.ToDecimal(strlist[strlist.Length - 1]);

            return price;
        }

        public decimal GetPricePetFood(string comboStr)
        {
            decimal price = 0;
            char[] seperator = { '-' };
            int count = 2;

            String[] strlist = comboStr.Split(seperator, count, StringSplitOptions.None);
            price = Convert.ToDecimal(strlist[strlist.Length - 1]);

            return price;
        }
        //===================================================================================================
        //var customers = _customerRepo.GetAll();
        //var employees = _employeeRepo.GetAll();
        //var pets = _petRepo.GetAll();
        //var petfoods = _petFoodRepo.GetAll();

        public void MonthGrab()
        {
            var transactions = _transactionRepo.GetAll().ToList();
            var pets = _petRepo.GetAll().ToList();
            decimal totalIncMonth = 0;

            var orderedTrans = transactions.OrderBy(m => m.Date.Month).ToList();

            for (int i = 1; i < 13; i++)
            {
                var monthly = orderedTrans.DistinctBy(m => m.Date.Month == i).ToList();
                //Monthly Income
                foreach (var totalPrice in monthly)
                {
                    totalIncMonth += totalPrice.TotalPrice;
                }
                //Monthly Expense
                decimal cleanPetFoodCost = 0;
                foreach (var pFood in transactions)
                {
                    if (pFood.PetPrice != 0)
                    {
                        cleanPetFoodCost += pFood.PetFoodPrice * (pFood.PetFoodQty - 1);
                    }
                    else
                        cleanPetFoodCost += pFood.PetFoodPrice * pFood.PetFoodQty;

                }
                //Monthly Expense
                decimal petCost = 0;
                foreach (var pet in pets)
                {
                   petCost += pet.Cost;
                }

            }
        }

        public decimal StableExpences()
        {
            decimal standardExpense = 0;
            decimal rent = 2000;
            var pets = _petRepo.GetAll().ToList();
            var transactions = _transactionRepo.GetAll().ToList();
            var employees = _employeeRepo.GetAll().ToList();
            var petFood = _petFoodRepo.GetAll().ToList();


            foreach (var employee in employees)
            {
                standardExpense += employee.SalaryPerMonth;
            }


            standardExpense += rent;
            return standardExpense;
        }



        //public List<decimal>(){}
































    }
}
