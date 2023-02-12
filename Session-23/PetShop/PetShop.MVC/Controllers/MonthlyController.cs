using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetShop.EF.Repositories;
using PetShop.Model;

namespace PetShop.MVC.Controllers
{
    public class MonthlyController : Controller
    {
        // GET: MonthlyController
        private readonly IEntityRepo<Customer> _customerRepo;
        private readonly IEntityRepo<Employee> _employeeRepo;
        private readonly IEntityRepo<Pet> _petRepo;
        private readonly IEntityRepo<PetFood> _petFoodRepo;
        private readonly IEntityRepo<Transaction> _transactionRepo;

        public MonthlyController(IEntityRepo<Customer> customer, IEntityRepo<Employee> employeeRepo, IEntityRepo<Pet> petRepo, IEntityRepo<PetFood> petFoodRepo, IEntityRepo<Transaction> transactionRepo)
        {
            _customerRepo = customer;
            _employeeRepo = employeeRepo;
            _petRepo = petRepo;
            _petFoodRepo = petFoodRepo;
            _transactionRepo = transactionRepo;
        }
        public ActionResult Index()
        {
         
            
            
            
            
            
            
            
            
            
            return View();
        }

        // GET: MonthlyController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MonthlyController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MonthlyController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MonthlyController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MonthlyController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MonthlyController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MonthlyController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
