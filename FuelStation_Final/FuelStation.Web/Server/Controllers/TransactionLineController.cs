using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FuelStation.EF.Repositories;
using FuelStation.Model;
using FuelStation.Web.Shared;
using FuelStation.Web.Shared.Services_Logic;
using FuelStation.Web.Shared.ManagerStaffSharedDTOs;
using FuelStation.Model.Enums;

namespace FuelStation.Web.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TransactionLineController : ControllerBase
    {

        private readonly IEntityRepo<Transaction> _transactionRepo;
        private readonly IEntityRepo<Customer> _customerRepo;
        private readonly IEntityRepo<Employee> _employeeRepo;
        private readonly IEntityRepo<Item> _itemRepo;
        private readonly IEntityRepo<TransactionLine> _transactionLineRepo;
        private TransactionHandler _transHandler;


        public TransactionLineController(IEntityRepo<Transaction> transactionRepo, IEntityRepo<Customer> customerRepo, IEntityRepo<Employee> employeeRepo, IEntityRepo<Item> itemRepo, IEntityRepo<TransactionLine> transLineRepo, TransactionHandler transHandler)
        {
            _transactionRepo = transactionRepo;
            _customerRepo = customerRepo;
            _employeeRepo = employeeRepo;
            _transactionLineRepo = transLineRepo;
            _transHandler = transHandler;

        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            var tr = _transactionLineRepo.GetById(id).TransactionID;
            _transactionLineRepo.Delete(id);
            
        }

        [HttpPut]
        public async Task<ActionResult> Put(TransactionLineEditDTO transLine)
        {
            var itemToUpdate = _transactionLineRepo.GetById(transLine.ID);
            itemToUpdate.ID = transLine.ID;
            itemToUpdate.TransactionID = transLine.TransactionId;
            itemToUpdate.Quantity = transLine.Quantity;
            itemToUpdate.ItemPrice = transLine.ItemPrice;
            itemToUpdate.NetValue = transLine.NetValue;
            itemToUpdate.DiscountPercent = transLine.DiscountPercent;
            itemToUpdate.DiscountValue = transLine.DiscountValue;
            itemToUpdate.TotalValue = transLine.TotalValue;
            _transactionLineRepo.Update(itemToUpdate.ID,itemToUpdate);
            return Ok();
        }


        [HttpPost]
        public async Task<ActionResult> Post(TransactionLineListDTO transLine)
        {
            
            var newTransactionLine = new TransactionLine();
            newTransactionLine.TransactionID = transLine.TransactionId;
            newTransactionLine.ItemID = transLine.ItemID;
            newTransactionLine.Quantity = transLine.Quantity;
            newTransactionLine.ItemPrice = newTransactionLine.ItemPrice; //seems shaky
            newTransactionLine.NetValue = transLine.NetValue;
            newTransactionLine.DiscountPercent = transLine.DiscountPercent;
            newTransactionLine.DiscountValue = transLine.DiscountValue;
            newTransactionLine.TotalValue = transLine.TotalValue;
            _transactionLineRepo.Add(newTransactionLine);
            return Ok();
        }







    }
}
