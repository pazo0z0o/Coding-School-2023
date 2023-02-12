using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetShop.EF.Repositories;
using PetShop.Model;
using PetShop.MVC.Models.Customer;

namespace PetShop.MVC.Controllers
{
    public class CustomerController : Controller
    {
        private readonly IEntityRepo<Customer> _customerRepo;
        private readonly IEntityRepo<Transaction> _transactionRepo;

        // GET: CustomerController
        public CustomerController(IEntityRepo<Customer> customRepo, IEntityRepo<Transaction> transactionRepo)
        {
            _customerRepo = customRepo;
            _transactionRepo = transactionRepo;
        }

        public ActionResult Index()
        {
            var customers = _customerRepo.GetAll().ToList();
            return View(model: customers);
        }

        // GET: CustomerController/Details/5

        public ActionResult Details(int? id)
        {
            if (id == null) { return NotFound(); }

            var customers = _customerRepo.GetById(id);
            if (customers == null) { return NotFound(); }

            var viewCustomer = new CustomerDetailsDTO()
            {
                Id = customers.Id,
                Name = customers.Name,
                Surname = customers.Surname,
                Phone = customers.Phone,
                Tin = customers.Tin,
                Transactions = customers.Transactions
            };
            return View(model: viewCustomer);
        }

        // GET: CustomerController/Create
        public ActionResult AddCustomer()
        {
            var newCustomer = new CustomerCreateDTO();
            var transactions = _transactionRepo.GetAll();

            return View(model: newCustomer);
        }

        // POST: CustomerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddCustomer(CustomerCreateDTO cus)
        {
            var newCustomer = new CustomerCreateDTO();
            if (!ModelState.IsValid) return View();

            var dbCustomer = new Customer(cus.Name, cus.Surname, cus.Phone, cus.Tin);


            _customerRepo.Add(dbCustomer);
            return RedirectToAction("Index"); // meta ap to add, se stelnei ksana sti lista tin arxiki me to GetAll()    
        }

        // GET: CustomerController/Edit/5
        public ActionResult Edit(int? id)
        {
            var dbCustomer = _customerRepo.GetById(id);
            if (dbCustomer == null)
            {
                return NotFound();
            }

            var viewCustomer = new CustomerEditDTO()
            {
                Id = dbCustomer.Id,
                Name= dbCustomer.Name,
                Surname= dbCustomer.Surname,
                Phone = dbCustomer.Phone,
                Tin = dbCustomer.Tin,
//Transactions = dbCustomer.Transactions
            };
            return View(model: viewCustomer);
        }

        // POST: CustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int? id, CustomerEditDTO edit)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var dbCustomer = _customerRepo.GetById(id);
            if (dbCustomer == null)
            {
                return NotFound();
            }
            dbCustomer.Id = edit.Id;
            dbCustomer.Name = edit.Name;
            dbCustomer.Surname = edit.Surname;
            dbCustomer.Phone = edit.Phone;
            dbCustomer.Tin = edit.Tin; 
            //dbCustomer.Transactions = edit.Transactions;

            _customerRepo.Update(id, dbCustomer);
            return RedirectToAction(nameof(Index));
        }

        // GET: CustomerController/Delete/5
        public ActionResult Delete(int id)
        {
            var dbCustomer = _customerRepo.GetById(id);
            if (dbCustomer == null)
            {
                return NotFound();
            }

            var viewCustomer = new CustomerDeleteDTO
            {
                Id = dbCustomer.Id,
                Name = dbCustomer.Name,
                Surname = dbCustomer.Surname,
                Phone = dbCustomer.Phone,
                Tin = dbCustomer.Tin,
                //Transactions = dbCustomer.Transactions
            };
            return View(model: viewCustomer);
        }

        // POST: CustomerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            _customerRepo.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
