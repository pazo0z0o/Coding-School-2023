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

        public void Delete(int? id)
        {
            using var context = new PetShopDbContext();
            var dbPetShop = context.Pets.Where(pets => pets.Id == id).SingleOrDefault();
            if (dbPetShop is null)
                return;
            context.Remove(dbPetShop);
            context.SaveChanges();
        }

        public IEnumerable<Pet> GetAll()
        {
            using var context = new PetShopDbContext();
            return context.Pets.Include(pets => pets.Transactions).ToList();
        }

        public Pet? GetById(int? id)
        {
            using var context = new PetShopDbContext();
            return context.Pets.Where(pets => pets.Id == id).Include(pets => pets.Transactions).SingleOrDefault();
        }

        public void Update(int? id, Pet entity)
        {
            using var context = new PetShopDbContext();
            var dbPetShop = context.Pets.Where(emps => emps.Id == id).SingleOrDefault();
            if (dbPetShop is null)
                return;
            dbPetShop.PetStatus = entity.PetStatus;
            dbPetShop.AnimalType = entity.AnimalType;
            dbPetShop.Breed = entity.Breed;
            dbPetShop.Price = entity.Price;
            dbPetShop.Cost = entity.Cost;
            // dbPetShop.Transacts = entity.Transacts;
            context.SaveChanges();
        }
    }
}
