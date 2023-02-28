using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FuelStation.EF.Repositories;
using FuelStation.Model;
using FuelStation.Model.Enums;
using FuelStation.Web.Shared;
using FuelStation.Web.Shared.Services_Logic;
using FuelStation.Web.Shared.ManagerStaffSharedDTOs;
using FuelStation.Web.Shared.ManagerOnlyDTOs;
using FuelStation.Web.Shared.ItemDTOs;




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


        public TransactionController(IEntityRepo<Transaction> transactionRepo, IEntityRepo<Customer> customerRepo, IEntityRepo<Employee> employeeRepo, IEntityRepo<Item> itemRepo, IEntityRepo<TransactionLine> transLineRepo, TransactionHandler transHandler)
        {
            _transactionRepo = transactionRepo;
            _customerRepo = customerRepo;
            _employeeRepo = employeeRepo;
            _transLineRepo = transLineRepo;
            _transHandler = transHandler;

        }

        [HttpGet]
        public async Task<IEnumerable<TransactionListDTO>> Get()
        {
            var result = _transactionRepo.GetAll().ToList();

            var transList = result.Select(transaction => new TransactionListDTO
            {
                ID = transaction.ID,
                Date = transaction.Date,
                TotalValue = transaction.TotalValue,
                CustomerId = transaction.CustomerId,
                EmployeeId = transaction.EmployeeId,
                PaymentMethod = transaction.PaymentMethod,
                TransactionLines = transaction.TransactionLines.Select(t => new TransactionLineListDTO()
                {
                    ID = t.ID,
                    Quantity = t.Quantity,
                    ItemPrice = t.ItemPrice,
                    NetValue = t.NetValue,
                    DiscountPercent = t.DiscountPercent,
                    DiscountValue = t.DiscountValue,
                    TotalValue = t.TotalValue,

                }).ToList()
            });
            return transList;
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            _transactionRepo.Delete(id);
        }

        [HttpPost]
        public async Task<ActionResult> Post(TransactionListDTO transaction)
        {
            Transaction newTransaction = new Transaction(transaction.PaymentMethod, transaction.TotalValue, transaction.Date)
            {
                ID = transaction.ID,
                CustomerId = transaction.CustomerId,
                EmployeeId = transaction.EmployeeId,
                TransactionLines = null!
            };
            _transactionRepo.Add(newTransaction);
            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<TransactionEditDTO> GetById(int id)
        {

            var result = _transactionRepo.GetById(id);
            result.TotalValue = _transHandler.CalculateTotalValue(result);// implement it
            var resultEmployee = _employeeRepo.GetAll();
            var resultCustomer = _customerRepo.GetAll();

            var transaction = new TransactionEditDTO
            {
                ID = id,
                Date = result.Date,
                CustomerId = result.CustomerId,
                EmployeeId = result.EmployeeId,
                PaymentMethod = result.PaymentMethod,
                TotalValue = result.TotalValue,

                ////TransactionLines = result.TransactionLines.Select(transactionLine => new TransactionLineEditDTO
                //{
                //    ID = transactionLine.ID,
                //    Quantity = transactionLine.Quantity,
                //    ItemPrice = transactionLine.ItemPrice, //<select> with bind-Value:"@Item.Price "
                //    NetValue = transactionLine.NetValue,
                //    DiscountPercent = transactionLine.DiscountPercent,
                //    DiscountValue = transactionLine.DiscountValue,
                //    TotalValue = transactionLine.TotalValue
                //}).ToList()
            };
            return transaction;
        }

        [HttpPut]
        public async Task<ActionResult> Put(TransactionEditDTO transaction)
        {
            var transactionUpdate = _transactionRepo.GetById(transaction.ID);
            transactionUpdate.TotalValue = transaction.TotalValue;
            transactionUpdate.CustomerId = transaction.CustomerId;
            transactionUpdate.EmployeeId = transaction.EmployeeId;
            transactionUpdate.PaymentMethod = transaction.PaymentMethod;

            _transactionRepo.Update(transaction.ID, transactionUpdate);
            return Ok();

        }

    }
}

