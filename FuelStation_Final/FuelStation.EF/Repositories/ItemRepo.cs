using FuelStation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuelStation.EF.Context;
using Microsoft.EntityFrameworkCore;

namespace FuelStation.EF.Repositories
{
    public class ItemRepo : IEntityRepo<Item>
    {
        public void Add(Item item)
        {
            using var context = new FuelStationDbContext();
            context.Add(item);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new FuelStationDbContext();
            var ItemDb = context.Items
                .Where(item => item.ID == id)
                .Include(item => item.TransactionLines)
                .SingleOrDefault();
            if (ItemDb is null)
                throw new KeyNotFoundException($"Given id '{id}' was not found");
            context.Remove(ItemDb);
            context.SaveChanges();
        }

        public IList<Item> GetAll()
        {
            using var context = new FuelStationDbContext();
            return context.Items
                .Include(item => item.TransactionLines)
                .ToList();
        }

        public Item? GetById(int id)
        {
            using var context = new FuelStationDbContext();
            return context.Items
                .Where(item => item.ID == id)
                .Include(item => item.TransactionLines)
                .SingleOrDefault();
        }

        public void Update(int id, Item item)
        {
            using var context = new FuelStationDbContext();
            var ItemDb = context.Items
              .Where(item => item.ID == id)
                .Include(item => item.TransactionLines)
                .SingleOrDefault();
            if (ItemDb is null) throw new KeyNotFoundException($"Given id '{id}' was not found");
            ItemDb.Code = item.Code;
            ItemDb.Description = item.Description;
            ItemDb.ItemType = item.ItemType;
            ItemDb.Price = item.Price;
            ItemDb.Cost = item.Cost;           
            context.SaveChanges();
        }
    }
}
