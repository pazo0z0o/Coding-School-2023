using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FuelStation.EF.Repositories;
using FuelStation.Model;
using FuelStation.Web.Shared;

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

    }
}
