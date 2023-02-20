using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FuelStation.EF.Repositories;
using FuelStation.Model;
using FuelStation.Web.Shared;
using FuelStation.Web.Shared.ManagerStaffSharedDTOs;
using FuelStation.Web.Shared.ManagerOnlyDTOs;

namespace FuelStation.Web.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EmployeeController : Controller
    {
      private readonly IEntityRepo<Employee> _employeeRepo;
        private readonly IEntityRepo<FuelStation.Model.Transaction> _transactionRepo;


        public EmployeeController(IEntityRepo<Employee> employeeRepo)
        {
            _employeeRepo= employeeRepo;
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
                SallaryPerMonth= employee.SallaryPerMonth,
                EmployeeType = employee.EmployeeType,
            });
        }

        [HttpPost]
        public async Task Post(EmployeeListDTO employee)
        {
            var newEmployee = new Employee();

                newEmployee.Name = employee.Name;
                newEmployee.Surname = employee.Surname;
                newEmployee.HireDateStart = employee.HireDateStart;
                newEmployee.HireDateEnd = employee.HireDateEnd;
                newEmployee.SallaryPerMonth = employee.SallaryPerMonth;    
                newEmployee.EmployeeType = employee.EmployeeType;
                newEmployee.Transactions = new();
                _employeeRepo.Add(newEmployee);
        }


        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            _employeeRepo.Delete(id);
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
                SallaryPerMonth= result.SallaryPerMonth,
                EmployeeType = result.EmployeeType
            };
        }
        //Put
        public async Task Put(EmployeeListDTO employee)
        {
            var itemToUpdate = _employeeRepo.GetById(employee.ID);
            itemToUpdate.ID = employee.ID;
            itemToUpdate.Name = employee.Name;
            itemToUpdate.Surname = employee.Surname;
            itemToUpdate.HireDateStart = employee.HireDateStart;
            itemToUpdate.HireDateEnd = employee.HireDateEnd;
            itemToUpdate.SallaryPerMonth= employee.SallaryPerMonth;
            itemToUpdate.EmployeeType = employee.EmployeeType;
            itemToUpdate.Transactions = employee.Transactions;
            _employeeRepo.Update(employee.ID, itemToUpdate);
        }


    }
}
