using Microsoft.EntityFrameworkCore;
using Session_16.EF.Models;
using Session_16.EF.PetShop.Orm.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_16.EF.PetShop.Orm.Repositories
{
    public class PetFoodRepo : IEntity<PetFood>
    {
        public void Add(PetFood entity)
        {
            using var context = new AppDbContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            using var context = new AppDbContext();
            var dbPetShop = context.PetFoods.Where(pfs => pfs.PetFoodID == id).SingleOrDefault();
            if (dbPetShop is null)
                return;
            context.Remove(dbPetShop);
            context.SaveChanges();
        }

        public IList<PetFood> GetAll()
        {
            using var context = new AppDbContext();
            return context.PetFoods.Include(pfs => pfs.Transacts).ToList();
        }

        public PetFood? GetById(Guid id)
        {
            using var context = new AppDbContext();
            return context.PetFoods.Where(pfs => pfs.PetFoodID == id).Include(pfs => pfs.Transacts).SingleOrDefault();
        }

        public void Update(Guid id, PetFood entity)
        {
            using var context = new AppDbContext();
            var dbPetShop = context.PetFoods.Where(pfs => pfs.PetFoodID == id).SingleOrDefault();
            if (dbPetShop is null)
                return;
            dbPetShop.Animaltype = entity.Animaltype;
            dbPetShop.Price = entity.Price;
            dbPetShop.Cost = entity.Cost;
            dbPetShop.Qty = entity.Qty;
            dbPetShop.CurrentStock = entity.CurrentStock;
            //dbPetShop.Transacts = entity.Transacts;
            context.SaveChanges();

        }
    }
}
