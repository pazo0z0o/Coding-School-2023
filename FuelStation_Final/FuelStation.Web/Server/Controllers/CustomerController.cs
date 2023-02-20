using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FuelStation.EF.Repositories;
using FuelStation.Model;
using FuelStation.Web.Shared;
using FuelStation.Web.Shared.ManagerStaffSharedDTOs;

namespace FuelStation.Web.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IEntityRepo<Customer> _customerRepo;
        public CustomerController(IEntityRepo<Customer> customerRepo)
        {
            _customerRepo = customerRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<CustomerListDTO>> Get()
        {
            var customerList = _customerRepo.GetAll();
            return customerList.Select(customer => new CustomerListDTO
            {
                ID = customer.ID,
                Name = customer.Name,
                Surname = customer.Surname,
                CardNumber = customer.CardNumber,
            });
        }

        [HttpPost]
        public async Task Post(CustomerCreateDTO customer)
        {
            var newCustomer = new Customer(customer.Name, customer.Surname, customer.CardNumber);
            newCustomer.Transactions = new();
            _customerRepo.Add(newCustomer);
        }


        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            _customerRepo.Delete(id);
        }


        [HttpGet("{id}")]
        public async Task<CustomerEditDTO> GetById(int id)
        {
            var result = _customerRepo.GetById(id);
            return new CustomerEditDTO
            {
                ID = id,
                Name = result.Name,
                Surname = result.Surname,
                CardNumber = result.CardNumber
            };
        }
        //Put
        public async Task Put(CustomerEditDTO customer)
        {
            var itemToUpdate = _customerRepo.GetById(customer.ID);
            itemToUpdate.ID = customer.ID;
            itemToUpdate.Name = customer.Name;
            itemToUpdate.Surname = customer.Surname;
            itemToUpdate.CardNumber = customer.CardNumber;            
            itemToUpdate.Transactions = customer.Transactions;
            _customerRepo.Update(customer.ID, itemToUpdate);
        }










    }
}
