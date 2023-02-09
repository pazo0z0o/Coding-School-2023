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
    public class PetFoodRepo : IEntity<PetFood>
    {
        public void Add(PetFood entity)
        {
            using var context = new PetShopDbContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new PetShopDbContext();
            var dbPetShop = context.PetFoods.Where(pfs => pfs.Id == id).SingleOrDefault();
            if (dbPetShop is null)
                return;
            context.Remove(dbPetShop);
            context.SaveChanges();
        }

        public IEnumerable<PetFood> GetAll()
        {
            using var context = new PetShopDbContext();
            return context.PetFoods.Include(pfs => pfs.Transactions).ToList();
        }

        public PetFood? GetById(int id)
        {
            using var context = new PetShopDbContext();
            return context.PetFoods.Where(pfs => pfs.Id == id).Include(pfs => pfs.Transactions).SingleOrDefault();
        }

        public void Update(int id, PetFood entity)
        {
            using var context = new PetShopDbContext();
            var dbPetShop = context.PetFoods.Where(pfs => pfs.Id == id).SingleOrDefault();
            if (dbPetShop is null)
                return;
            dbPetShop.AnimalType = entity.AnimalType;
            dbPetShop.Price = entity.Price;
            dbPetShop.Cost = entity.Cost;
           // dbPetShop.Qty = entity.Qty;
          //  dbPetShop.CurrentStock = entity.CurrentStock;
            //dbPetShop.Transacts = entity.Transacts;
            context.SaveChanges();
        }
    }
}
