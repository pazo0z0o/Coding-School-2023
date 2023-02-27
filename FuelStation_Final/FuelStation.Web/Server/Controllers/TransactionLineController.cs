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
           // _transHandler.CalculateTotalValue(_transactionRepo.GetById(tr));
        }

        [HttpPut]
        public async Task<ActionResult> Put(TransactionLineEditDTO transLine)
        {
            var trans = _transactionRepo.GetById(transLine.TransactionId);
            var itemToUpdate = _transactionLineRepo.GetById(transLine.ID);
            itemToUpdate.ID = transLine.ID;
            //itemToUpdate.TransactionId = transLine.TransactionId;
            itemToUpdate.Quantity = transLine.Quantity;
            itemToUpdate.ItemPrice = _itemRepo.GetById(transLine.ItemID).Price;
            itemToUpdate.NetValue = transLine.NetValue; 
            itemToUpdate.DiscountPercent = transLine.DiscountPercent;
            itemToUpdate.DiscountValue = transLine.DiscountValue;
            itemToUpdate.TotalValue = transLine.TotalValue;         //Could call a method to auto update
            if (_transHandler.HasMultipleFuelLines(trans))
            {
                _transactionLineRepo.Add(itemToUpdate);


                itemToUpdate.NetValue = _transHandler.CalcNetValue(itemToUpdate);
                if (itemToUpdate.Item.ItemType == ItemType.Fuel && itemToUpdate.NetValue > 20)
                {
                    itemToUpdate.DiscountPercent = 0.10M;
                    itemToUpdate.DiscountValue = _transHandler.CalculateDiscountValue(itemToUpdate);
                }
                itemToUpdate.TotalValue = _transHandler.CalcTransactionLineTotal(itemToUpdate);
                _transactionLineRepo.Update(itemToUpdate.ID, itemToUpdate);
                var tmpTrans = _transactionRepo.GetById(itemToUpdate.TransactionID);
                _transactionRepo.Update(itemToUpdate.TransactionID, tmpTrans);
                return Ok();
            }
            else
            {
                return StatusCode(StatusCodes.Status406NotAcceptable,
                "Only one transaction line may have Fuel as an Item");
            }                                                        
        }


        [HttpPost]
        public async Task<ActionResult> Post(TransactionLineListDTO transLine)
        {
            var trans = _transactionRepo.GetById(transLine.TransactionId);
            var newTransactionLine = new TransactionLine();
            newTransactionLine.TransactionID = transLine.TransactionId;
            newTransactionLine.ItemID = transLine.ItemID;
            newTransactionLine.Quantity = transLine.Quantity;
            newTransactionLine.ItemPrice = newTransactionLine.ItemPrice; //seems shaky
            newTransactionLine.NetValue = 0;
            newTransactionLine.DiscountPercent = transLine.DiscountPercent;
            newTransactionLine.DiscountValue = 0;
            newTransactionLine.TotalValue = 0;

            // var tmpTransLine = _transactionLineRepo.GetById(newTransactionLine.ID);
            if (_transHandler.HasMultipleFuelLines(trans))
            {
                _transactionLineRepo.Add(newTransactionLine);


                newTransactionLine.NetValue = _transHandler.CalcNetValue(newTransactionLine);
                if (newTransactionLine.Item.ItemType == ItemType.Fuel && newTransactionLine.NetValue > 20)
                {
                    newTransactionLine.DiscountPercent = 0.10M;
                    newTransactionLine.DiscountValue = _transHandler.CalculateDiscountValue(newTransactionLine);
                }
                newTransactionLine.TotalValue = _transHandler.CalcTransactionLineTotal(newTransactionLine);
                _transactionLineRepo.Update(newTransactionLine.ID, newTransactionLine);
                var tmpTrans = _transactionRepo.GetById(newTransactionLine.TransactionID);
                _transactionRepo.Update(newTransactionLine.TransactionID, tmpTrans);
                return Ok();
            }
            else
            {
                return StatusCode(StatusCodes.Status406NotAcceptable,
                "Only one transaction line may have Fuel as an Item");
            }
        }



    }
}
