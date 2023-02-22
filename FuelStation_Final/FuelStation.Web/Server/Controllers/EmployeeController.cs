using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FuelStation.EF.Repositories;
using FuelStation.Model;
using FuelStation.Web.Shared;
using FuelStation.Web.Shared.ManagerStaffSharedDTOs;
using FuelStation.Web.Shared.ManagerOnlyDTOs;
using FuelStation.Web.Shared.Services_Logic;
using Microsoft.EntityFrameworkCore;

namespace FuelStation.Web.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EmployeeController : Controller
    {
      private readonly IEntityRepo<Employee> _employeeRepo;
       // private readonly IEntityRepo<FuelStation.Model.Transaction> _transactionRepo;
        private TransactionHandler _transHandler;
        private RandomGenerators _randomGen;

        public EmployeeController(IEntityRepo<Employee> employeeRepo, TransactionHandler transHandler, RandomGenerators randomGen)
        {
            _employeeRepo= employeeRepo;
            _transHandler= transHandler;
            _randomGen= randomGen;
        }


        [HttpGet]
        public async Task<IEnumerable<EmployeeListDTO>> Get()
        {
            var employeelist = _employeeRepo.GetAll();
            return employeelist.Select(employee => new EmployeeListDTO
            {
                ID = employee.ID,
                Name = employee.Name,
                Surname = employee.Surname,
                HireDateStart = employee.HireDateStart,
                HireDateEnd = employee.HireDateEnd,
                SalaryPerMonth = employee.SalaryPerMonth,
                EmployeeType = employee.EmployeeType
            });
        }

        [HttpPost]
        public async Task<ActionResult> Post(EmployeeListDTO employee)
        {   
            var employees = _employeeRepo.GetAll().ToList(); //weird error here? without ToList()
            string msg = "Success";
            string datesMsg = "Success";
            var newEmployee = new Employee();
                newEmployee.Name = employee.Name;
                newEmployee.Surname = employee.Surname;
                newEmployee.HireDateStart = employee.HireDateStart;
                newEmployee.HireDateEnd = employee.HireDateEnd;
                newEmployee.SalaryPerMonth = employee.SalaryPerMonth;    
                newEmployee.EmployeeType = employee.EmployeeType;
                newEmployee.Transactions = new();
            if (_transHandler.EmployeeUpperLimitCheck(newEmployee.EmployeeType, employees, out msg))
            {
                _employeeRepo.Add(newEmployee);
                return Ok();
            }
            else return BadRequest(msg);
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {//validate for minumum Employees
            string msg = "Success"; 
            List<Employee> singleEmployee = new List<Employee>();
            var selectedEmployee = _employeeRepo.GetById(id);
     //this is such a dumb way to do this,use lambda when I get back to it    
            singleEmployee.Add(selectedEmployee); 
            if (_transHandler.EmployeeLowerLimitCheck(selectedEmployee.EmployeeType,singleEmployee,out msg))
            {
               _employeeRepo.Delete(id);
                return Ok();
            }
            else return BadRequest(msg);

        }


        [HttpGet("{id}")]
        public async Task<EmployeeListDTO> GetById(int id)
        { 
            var result = _employeeRepo.GetById(id);
            return new EmployeeListDTO
            {
                ID = id,
                Name = result.Name,
                Surname = result.Surname,
                HireDateStart = result.HireDateStart,
                HireDateEnd = result.HireDateEnd,
                SalaryPerMonth = result.SalaryPerMonth,
                EmployeeType = result.EmployeeType
            };
        }
        //Put
        public async Task Put(EmployeeEditDTO employee)
        {
            var itemToUpdate = _employeeRepo.GetById(employee.ID);
            itemToUpdate.ID = employee.ID;
            itemToUpdate.Name = employee.Name;
            itemToUpdate.Surname = employee.Surname;
           // itemToUpdate.HireDateStart = employee.HireDateStart;
            itemToUpdate.HireDateEnd = employee.HireDateEnd;
            itemToUpdate.SalaryPerMonth = employee.SalaryPerMonth;
            itemToUpdate.EmployeeType = employee.EmployeeType;
            itemToUpdate.Transactions = employee.Transactions;
            _employeeRepo.Update(employee.ID, itemToUpdate);
        }


    }
}
