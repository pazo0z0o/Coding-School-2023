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
    public class PetFoodRepo : IEntityRepo<PetFood>
    {
        public void Add(PetFood entity)
        {
            using var context =new PetShopDbContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new PetShopDbContext();
            var dbPetFood = context.PetFoods.Where(pf => pf.Id == id).SingleOrDefault();
            if (dbPetFood is null) { throw new KeyNotFoundException($"Given id '{id}' was not found"); }
            
                context.Remove(dbPetFood);
                context.SaveChanges();
            
        }

        public IList<PetFood> GetAll()
        {
            using var context = new PetShopDbContext();
            return context.PetFoods.Include(pf => pf.TransactionLines).Include(pf => pf.Stock).ToList();
        }

        public PetFood? GetById(int id)
        {
            using var context = new PetShopDbContext();
            return context.PetFoods.Where(pf=>pf.Id == id)
                .Include(pf => pf.TransactionLines).Include(pf=>pf.Stock)
                .SingleOrDefault();
        }

        public void Update(int id, PetFood entity)
        {
            using var context = new PetShopDbContext();
            var dbPetFood = context.PetFoods.Where(pf => pf.Id == id).SingleOrDefault();
            if(dbPetFood is null) { throw new KeyNotFoundException("The chosen PetFood Id"); }
            dbPetFood.AnimalType = entity.AnimalType;
            dbPetFood.PetFoodQuality = entity.PetFoodQuality;
            dbPetFood.Price = entity.Price;
            dbPetFood.Cost = entity.Cost;
            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
