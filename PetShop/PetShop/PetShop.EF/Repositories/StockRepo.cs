using Microsoft.EntityFrameworkCore;
using PetShop.EF.Context;
using PetShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.EF.Repositories
{
    public class StockRepo : IEntityRepo<Stock>
    { 
        public void Add(Stock entity)
        {
            using var context = new PetShopDbContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new PetShopDbContext();
            var dbStock = context.Stock.Where(stock => stock.Id == id)
                .Include(stock => stock.PetFoods)
                .SingleOrDefault();
            if (dbStock is null) return;
            context.Remove(dbStock);
            context.SaveChanges();       
        }

        public IList<Stock> GetAll()
        {
            using var context = new PetShopDbContext();
            return context.Stock.Include(stock => stock.PetFoods).ToList();
        }

        public Stock? GetById(int id)
        {
            using var context = new PetShopDbContext();
            return context.Stock.Where(stock => stock.Id == id).Include(stock => stock.PetFoods).SingleOrDefault();
        }

        public void Update(int id, Stock entity)
        {
            using var context = new PetShopDbContext();
            var dbStock = context.Stock.Where(stock => stock.Id == id).SingleOrDefault();
            if(dbStock is null)
            {
                throw new KeyNotFoundException($"Given id '{id}' was not found");
                return;
            }
            dbStock.AnimalType = entity.AnimalType;
            dbStock.PetFoodQuality = entity.PetFoodQuality;
            dbStock.StockQuantity = entity.StockQuantity;
            dbStock.Month = entity.Month;
            dbStock.Year = entity.Year;
            context.SaveChanges();
        }
    }
}
