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
    public class PetRepo : IEntityRepo<Pet>
    {
        public void Add(Pet entity)
        {
            using var context = new PetShopDbContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new PetShopDbContext();
            var dbPets = context.Pets.Where(p => p.Id == id).SingleOrDefault();
            if (dbPets is null) { throw new KeyNotFoundException("The given key was not found!"); }
            context.SaveChanges();
        }

        public IList<Pet> GetAll()
        {
            using var context = new PetShopDbContext();
            return context.Pets.Include(p => p.TransactionLines).ToList();

        }

        public Pet? GetById(int id)
        {
            using var context = new PetShopDbContext();
            var dbPets = context.Pets.Where(p => p.Id == id)
                .Include(p => p.TransactionLines)
                .SingleOrDefault();
            return dbPets;
        }

        public void Update(int id, Pet entity)
        {
            using var context = new PetShopDbContext();
            var dbPets = context.Pets.Where(p => p.Id == id).SingleOrDefault();
            if (dbPets is null)
            {
                throw new KeyNotFoundException("The given key was not found!");
            }
            else
            {
                dbPets.Breed = entity.Breed;
                dbPets.Price = entity.Price;
                dbPets.AnimalType = entity.AnimalType;
                dbPets.PetStatus = entity.PetStatus;
                dbPets.Cost = entity.Cost;
            }
            try { context.SaveChanges(); }
            catch (Exception ex)
            {
                throw ex; 
            }
        }
    }
}
