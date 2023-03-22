using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetShop.EF.Repositories;
using PetShop.SandBox.Shared;
using PetShop.Model;

namespace PetShop.SandBox.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly CustomerRepo _customerRepo;

        public CustomerController(CustomerRepo customerRepo)
        {
            _customerRepo = customerRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<CustomerListDTO>> GetAll()
        {
            var result = _customerRepo.GetAll();
            return result.Select(x => new CustomerListDTO
            {
                Id = x.Id,
                Name = x.Name,
                Surname = x.Surname

            });

        }
        [Route("customerList/details/{id}")]
        [HttpGet]
        public async Task<CustomerDetailsDTO> GetCustomerDetails(int id)
        {
            var result = _customerRepo.GetById(id);

            if (result is null) return null;

            CustomerDetailsDTO customerDetails = new()
            {
                Id = result.Id,
                Name = result.Name,
                Surname = result.Surname,
                Phone = result.Phone,
                Tin = result.Tin,
                //TODO: Get TransactionDetails done
                //Transactions = result.Transactions.Select(transact => new TransactionListDTO
                //{
                //    Date = transact.Date,
                //    TotalPrice = transact.TotalPrice,
                //}).ToList()
            };
            return customerDetails;
        }

        [HttpGet("{id:int}")]
        public async Task<CustomerDetailsDTO> GetById(int id)
        {
            var result = _customerRepo.GetById(id);

            if (result is null) { return null; }

            CustomerDetailsDTO customerDetails = new()
            {
                Id = result.Id,
                Name = result.Name,
                Surname = result.Surname,
                Phone = result.Phone,
                Tin = result.Tin,

            };
            return customerDetails;
        }
        [Route("customerList/edit")]
        [HttpPost]
        public async Task<ActionResult> Post(CustomerDetailsDTO customer)
        {
            var customerToAdd = new Customer
            {
                Id = customer.Id,
                Name = customer.Name,
                Surname = customer.Surname,
                Phone = customer.Phone,
                Tin = customer.Tin,
            };
            try
            { _customerRepo.Add(customerToAdd); }
            catch (Exception ex)
            {
                throw ex;
            }
            return Ok();
        }
        [Route("customerList/edit/{id}")]
        [HttpPut]
        public async Task<ActionResult> Put(CustomerEditDTO customer)
        {
            var customerToEdit = _customerRepo.GetById(customer.Id);
            if (customerToEdit is null) return StatusCode(StatusCodes.Status404NotFound, "Customer not found!");

            customerToEdit.Name = customer.Name;
            customerToEdit.Surname = customer.Surname;
            customerToEdit.Phone = customer.Phone;
            customerToEdit.Tin = customer.Tin;

            try
            {
                _customerRepo.Update(customer.Id, customerToEdit);
            }
            catch (Exception ex)
            {
                return BadRequest("Something Went Wrong");
            }
            return Ok();
        }
        [HttpDelete("{id:int}")]
        public async Task<ActionResult<CustomerListDTO>> Delete(int id)
        {
            try
            {
                var customer = _customerRepo.GetById(id);

                if (customer is null)
                {
                    return NotFound($"Customer with Id {id} not found");
                }

                _customerRepo.Delete(id);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error at deleting data");
            }
        }

    }
}
