using Microsoft.EntityFrameworkCore;
using Session_16.EF.Models;
using Session_16.EF.PetShop.Orm.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Session_16.EF.PetShop.Orm.Repositories
{
    public class TransactionRepo : IEntity<Transactions>
    {
        public void Add(Transactions entity)
        {
            using var context = new AppDbContext();
            context.Add(entity);
            context.SaveChanges();

        }

        public void Delete(Guid id)
        {
            using var context = new AppDbContext();
            var dbTodo = context.Transact.Where(trans => trans.TransID == id).SingleOrDefault();
            if (dbTodo is null)
                return;
            context.Remove(dbTodo);
            context.SaveChanges();

        }

        public IList<Transactions> GetAll()
        {
            using var context = new AppDbContext();
            return context.Transact.Include(trans => trans.Customer).Include(trans => trans.Employee).Include(trans => trans.Pfood).ToList();
        }

        public Transactions? GetById(Guid id)
        {

            using var context = new AppDbContext();
            return context.Transact.Where(trans => trans.TransID == id).Include(trans => trans.Customer).Include(trans => trans.Employee).Include(trans => trans.Pfood).SingleOrDefault();
                
               
        }

        

        public void Update(Guid id, Transactions entity)
        {
            using var context = new AppDbContext();
            var dbPetShop = context.Transact.Where(pfs => pfs.TransID == id).SingleOrDefault();
            if (dbPetShop is null)
                return;
            dbPetShop.Date = entity.Date;
            dbPetShop.Customer = entity.Customer;
            dbPetShop.Employee = entity.Employee;
            dbPetShop.Pets = entity.Pets;
            dbPetShop.Pfood = entity.Pfood;
            dbPetShop.PetPrice= entity.PetPrice;
            dbPetShop.PetFoodPrice = entity.PetFoodPrice;
            dbPetShop.PetFoodQty = entity.PetFoodQty;
            dbPetShop.TotalPrice = entity.TotalPrice;
            dbPetShop.TotalPrice = entity.TotalPrice;
            context.SaveChanges();
        }

       
    }
}


