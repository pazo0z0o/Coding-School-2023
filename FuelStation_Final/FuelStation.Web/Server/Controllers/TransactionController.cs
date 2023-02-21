using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FuelStation.EF.Repositories;
using FuelStation.Model;
using FuelStation.Web.Shared;
using FuelStation.Web.Shared.Services_Logic;

namespace FuelStation.Web.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly IEntityRepo<Transaction> _transactionRepo;
        private readonly IEntityRepo<Customer> _customerRepo;
        private readonly IEntityRepo<Employee> _employeeRepo;
        private readonly IEntityRepo<Item> _itemRepo;
        private readonly IEntityRepo<TransactionLine> _transLineRepo;
        private TransactionHandler _transHandler;
        private RandomGenerators _rangomGen;

        public TransactionController(IEntityRepo<Transaction> transactionRepo, IEntityRepo<Customer> customerRepo, IEntityRepo<Employee> employeeRepo, IEntityRepo<Item> itemRepo, IEntityRepo<TransactionLine> transLineRepo, TransactionHandler transHandler)
        {
            _transactionRepo = transactionRepo;
            _customerRepo = customerRepo;
            _employeeRepo = employeeRepo;
            _transLineRepo = transLineRepo;
            _transHandler = transHandler;
        }

        //[HttpGet]
        
        //[HttpDelete("{id}")]
       
        //[HttpPost]
        
        //[HttpGet("{id}")]

        //[HttpPut]














































    }

}

