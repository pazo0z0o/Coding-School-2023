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
    public class TransactionRepo : IEntityRepo<Transaction>
    {
        public void Add(Transaction entity)
        {
            using var context = new PetShopDbContext();
            context.Add(entity);


            context.SaveChanges();
        }

        public void Delete(int? id)
        {
            using var context = new PetShopDbContext();
            var dbTodo = context.Transactions.Where(trans => trans.Id == id).SingleOrDefault();
            if (dbTodo is null)
                return;
            context.Remove(dbTodo);
            context.SaveChanges();
        }

        public IEnumerable<Transaction> GetAll()
        {
            using var context = new PetShopDbContext();

            return context.Transactions.Include(trans => trans.Customer).Include(trans => trans.Employee).Include(trans => trans.Pet).Include(trans => trans.PetFood).ToList();
        }

        public Transaction? GetById(int? id)
        {
            using var context = new PetShopDbContext();
            //return context.Transactions.Where(trans => trans.TransID == id).Include(trans => trans.Customer).Include(trans => trans.Employee).Include(trans => trans.Pfood).SingleOrDefault();

            return context.Transactions.Where(trans => trans.Id == id).Include(trans => trans.Customer).Include(trans => trans.Employee).Include(trans => trans.Pet).Include(trans => trans.PetFood).SingleOrDefault();
        }

        public void Update(int? id, Transaction entity)
        {
            using var context = new PetShopDbContext();
            var dbPetShop = context.Transactions.Where(trans => trans.Id == id).SingleOrDefault();
            if (dbPetShop is null)
                return;
            dbPetShop.Date = entity.Date;
            dbPetShop.Customer = entity.Customer;
            dbPetShop.Employee = entity.Employee;
            dbPetShop.Pet = entity.Pet;
            dbPetShop.PetFood = entity.PetFood;
            dbPetShop.PetPrice = entity.PetPrice;
            dbPetShop.PetFoodPrice = entity.PetFoodPrice;
            dbPetShop.PetFoodQty = entity.PetFoodQty;
            dbPetShop.TotalPrice = entity.TotalPrice;
        }
    }
}
