using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FuelStation.EF.Repositories;
using FuelStation.Model;
using FuelStation.Web.Shared;
using FuelStation.Web.Shared;
using FuelStation.Web.Shared.ManagerStaffSharedDTOs;
using FuelStation.Web.Shared.ItemDTOs;
using FuelStation.Web.Shared.Services_Logic;

namespace FuelStation.Web.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        
        private readonly IEntityRepo<Item> _itemRepo;

        public ItemController(IEntityRepo<Item> itemRepo)
        {
            _itemRepo= itemRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<ItemListDTO>> Get()
        {
            var itemlist = _itemRepo.GetAll();
            return itemlist.Select(item => new ItemListDTO
            {
                ID = item.ID,
                Code = item.Code,                 
                Description = item.Description,
                ItemType = item.ItemType,
                Price = item.Price,
                Cost = item.Cost
            });
        }


        [HttpPost]
        public async Task Post(ItemListDTO item)
        {  
            var newItem = new Item();    
                newItem.Code = item.Code;                 
                newItem.Description = item.Description;
                newItem.ItemType = item.ItemType;
                newItem.Price = item.Price;
                newItem.Cost = item.Cost;
                newItem.TransactionLines = new();
                _itemRepo.Add(newItem);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            _itemRepo.Delete(id);
        }

        [HttpGet("{id}")]
        public async Task<ItemEditDTO> GetById(int id)
        {
            var result = _itemRepo.GetById(id);
            return new ItemEditDTO
            {
                ID = result.ID,
                Code = result.Code,
                Description = result.Description,
                ItemType = result.ItemType,
                Price = result.Price,
                Cost = result.Cost
            };
        }

        public async Task Put(ItemEditDTO item)
        {
            var itemToUpdate = _itemRepo.GetById(item.ID);
            itemToUpdate.ID = item.ID;
            itemToUpdate.Code = item.Code;
            itemToUpdate.Description = item.Description;
            itemToUpdate.ItemType = item.ItemType;
            itemToUpdate.Price = item.Price;
            itemToUpdate.Cost = item.Cost;
            itemToUpdate.TransactionLines = item.TransactionLines;
            _itemRepo.Update(item.ID, itemToUpdate);
        }





















    }
}


//public int ID { get; set; }
//public string Code { get; set; }
//public string Description { get; set; }
//public ItemType ItemType { get; set; }
//public decimal Price { get; set; }
//public decimal Cost { get; set; }