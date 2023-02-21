using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FuelStation.EF.Repositories;
using FuelStation.Model;
using FuelStation.Web.Shared;
using FuelStation.Web.Shared.Services_Logic;
using FuelStation.Web.Shared.ManagerStaffSharedDTOs;

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
        private RandomGenerators _randomGen;

        public TransactionLineController(IEntityRepo<Transaction> transactionRepo, IEntityRepo<Customer> customerRepo, IEntityRepo<Employee> employeeRepo, IEntityRepo<Item> itemRepo, IEntityRepo<TransactionLine> transLineRepo, TransactionHandler transHandler, RandomGenerators rangomGen)
        {
            _transactionRepo = transactionRepo;
            _customerRepo = customerRepo;
            _employeeRepo = employeeRepo;
            _transactionLineRepo = transLineRepo;
            _transHandler = transHandler;
            _randomGen = rangomGen;
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            var tr = _transactionLineRepo.GetById(id).TransactionID;
            _transactionLineRepo.Delete(id);
            // _transHandler.CalculateTotalCost(_transactionRepo.GetById(tr));   //FIX AND IMPLEMENT
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
            newTransactionLine.ItemPrice = transLine.ItemPrice;
            newTransactionLine.NetValue = transLine.NetValue;
            newTransactionLine.DiscountPercent = transLine.DiscountPercent;
            newTransactionLine.DiscountValue = transLine.DiscountValue;
            newTransactionLine.TotalValue = transLine.TotalValue;



            //newTransactionLine.TransactionId = transLine.TransactionId;
            //newTransactionLine.Hours = _serviceTaskRepo.GetById(transLine.ServiceTaskId).Hours;

            //if (_transHandler.ValidateInsertTransactionLine(trans, transLine))
            //{
            //    if (_transHandler.ValidateMaxWorkLoad(trans, newTransactionLine, _engineerRepo.GetAll().Count()))
            //    {
            //        _transactionLineRepo.Add(newTransactionLine);
            //        var tmpTrans = _transactionRepo.GetById(newTransactionLine.TransactionId);
            //        tmpTrans.TotalPrice = (_transHandler.CalculateTotalCost(tmpTrans));
            //        _transactionRepo.Update(transLine.TransactionId, tmpTrans);
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



    }
}
