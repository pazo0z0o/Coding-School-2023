using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetShop.EF.Repositories;
using PetShop.Model;
using PetShop.MVC.Models.Employee;

namespace PetShop.MVC.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEntityRepo<Employee> _employeeRepo;
        private readonly IEntityRepo<Transaction> _transactionRepo;

        public EmployeeController(IEntityRepo<Employee> employeeRepo, IEntityRepo<Transaction> transactionRepo)
        {
            _employeeRepo = employeeRepo;
            _transactionRepo = transactionRepo;
        }
        // GET: EmployeeController
        public ActionResult Index()
        {
            var employees = _employeeRepo.GetAll().ToList();
            return View(model: employees);
        }

        // GET: EmployeeController/Details/5
        public ActionResult Details(int? id)
        {   if( id == null ) return NotFound();

            var employees = _employeeRepo.GetById(id);
            if(employees == null ) return NotFound();

            var viewEmployee = new EmployeeDetailsDTO()
            {                   
                Id = employees.Id,
                Name = employees.Name,
                Surname = employees.Surname,
                EmployeeType= employees.EmployeeType,
                SalaryPerMonth= employees.SalaryPerMonth,
                Transactions = employees.Transactions
            };
            return View(model: viewEmployee);
        }

        // GET: EmployeeController/Create
        public ActionResult Create()
        {
            var newEmployee = new EmployeeCreateDTO();
            var transations = _transactionRepo.GetAll();
            return View();
        }

        // POST: EmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EmployeeCreateDTO emp)
        {
            if (!ModelState.IsValid) return View();

            var dbEmployee = new Employee(emp.Name, emp.Surname, emp.EmployeeType, emp.SalaryPerMonth);
            
            _employeeRepo.Add(dbEmployee);
             return RedirectToAction("Index");
        }

        // GET: EmployeeController/Edit/5
        public ActionResult Edit(int? id)
        {
            var dbEmployee = _employeeRepo.GetById(id);
            if (dbEmployee == null) return NotFound();

            var viewEmployee = new EmployeeEditDTO()
            {
              Id = dbEmployee.Id ,
              Name = dbEmployee.Name,
              Surname = dbEmployee.Surname,
              EmployeeType = dbEmployee.EmployeeType,
              SalaryPerMonth = dbEmployee.SalaryPerMonth,

            };
            return View(model: viewEmployee);
        }

        // POST: EmployeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int? id, EmployeeEditDTO emp)
        {    if (!ModelState.IsValid)
             {
                return View();
             }

            var dbEmployee = _employeeRepo.GetById(id);
            if(dbEmployee == null) return NotFound();

            dbEmployee.Name = emp.Name;
            dbEmployee.Surname = emp.Surname;
            dbEmployee.Id = emp.Id;
            dbEmployee.EmployeeType= emp.EmployeeType;
            dbEmployee.SalaryPerMonth = emp.SalaryPerMonth;
        
            _employeeRepo.Update(id, dbEmployee);
            return RedirectToAction(nameof(Index));
        }

        // GET: EmployeeController/Delete/5
        public ActionResult Delete(int id)
        {
            var dbEmployee = _employeeRepo.GetById(id);
            if(dbEmployee == null) return NotFound();

            var viewEmployee = new EmployeeDeleteDTO()
            {
                Id = dbEmployee.Id,
                Name = dbEmployee.Name,
                Surname = dbEmployee.Surname,
                EmployeeType = dbEmployee.EmployeeType,
                SalaryPerMonth = dbEmployee.SalaryPerMonth,

            };
            return View(model: viewEmployee);
        }

        // POST: EmployeeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            _employeeRepo.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
