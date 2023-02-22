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
            _transHandler.CalculateTotalValue(_transactionRepo.GetById(tr));
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
            itemToUpdate.NetValue = transLine.NetValue; //Could call a method to auto update
            itemToUpdate.DiscountPercent = transLine.DiscountPercent;
            itemToUpdate.DiscountValue = transLine.DiscountValue;
            itemToUpdate.TotalValue = transLine.TotalValue;//Could call a method to auto update
                                                           //itemToUpdate.Hours = _serviceTaskRepo.GetById(transLine.ServiceTaskId).Hours;
                                                           //itemToUpdate.ServiceTaskId = transLine.ServiceTaskId;
                                                           //if (_transHandler.ValidateUpdateTransactionLine(trans, transLine))
                                                           //{
                                                           //    if (_transHandler.ValidateMaxWorkLoad(trans, itemToUpdate, _engineerRepo.GetAll().Count()))
                                                           //    {
                                                           //        _transactionLineRepo.Update(transLine.Id, itemToUpdate);
                                                           //        var tmpTrans = _transactionRepo.GetById(itemToUpdate.TransactionId);
                                                           //        tmpTrans.TotalPrice = (_transHandler.CalculateTotalCost(tmpTrans));
                                                           //        _transactionRepo.Update(itemToUpdate.TransactionId, tmpTrans);
                                                           //        return Ok();
                                                           //    }
                                                           //    else
                                                           //    {
                                                           //        return StatusCode(StatusCodes.Status409Conflict,
                                                           //        "Max WorkLoad Reached");
                                                           //    }
                                                           //}
                                                           //else
                                                           //{
                                                           //    return StatusCode(StatusCodes.Status406NotAcceptable,
                                                           //   "Either Engineer Or Task exists in another TransactionLine");
                                                           //}
            return Ok();
        }


        [HttpPost]
        public async Task<ActionResult> Post(TransactionLineEditDTO transLine)
        {
            var trans = _transactionRepo.GetById(transLine.TransactionId);
            var newTransactionLine = new TransactionLine();
            newTransactionLine.TransactionID = transLine.TransactionId;
            newTransactionLine.ItemID = transLine.ItemID;
            newTransactionLine.Quantity = transLine.Quantity;
            newTransactionLine.ItemPrice = _itemRepo.GetById(newTransactionLine.ItemID).Price; //seems shaky
            newTransactionLine.NetValue = 0;
            newTransactionLine.DiscountPercent = transLine.DiscountPercent;
            newTransactionLine.DiscountValue = 0;
            newTransactionLine.TotalValue = 0;

            //create a temporary transaction for calculation purposes 
            var tmpTrans = _transactionRepo.GetById(newTransactionLine.TransactionID);
            var tmpTransLine = _transactionLineRepo.GetById(newTransactionLine.ID);

            tmpTransLine.NetValue = _transHandler.CalcNetValue(tmpTransLine);
            if (tmpTransLine.Item.ItemType == ItemType.Fuel && tmpTransLine.NetValue > 20)
            {
                tmpTransLine.DiscountPercent = 0.10M;
                tmpTransLine.DiscountValue = _transHandler.CalculateDiscountValue(tmpTransLine); }
            tmpTransLine.TotalValue = _transHandler.CalcTransactionLineTotal(tmpTransLine);   
           // tmpTrans.TotalValue = (_transHandler.CalculateTotalValueTransLine(tmpTrans));



            return Ok();
        }



    }
}
