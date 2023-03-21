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
    public class CustomerRepo : IEntityRepo<Customer>
    {
        public void Add(Customer entity)
        {
            using var context = new PetShopDbContext();

            context.Add(entity);

            context.SaveChanges();
        }

        public void Delete(int? id)
        {
            using var context = new PetShopDbContext();
            var dbPetShop = context.Customers.Where(customs => customs.Id == id).SingleOrDefault();
            if (dbPetShop is null)
                return;
            context.Remove(dbPetShop);
            context.SaveChanges();
        }

        public IEnumerable<Customer> GetAll()
        {
            using var context = new PetShopDbContext();
            return context.Customers;//.Include(customs => customs.Transactions).ToList();
        }

        public Customer? GetById(int? id)
        {
            using var context = new PetShopDbContext();   //could be a mistake to include Transactions
            return context.Customers.Include(customs => customs.Transactions).Where(customs => customs.Id == id).SingleOrDefault();
        }

        public void Update(int? id, Customer entity)
        {
            using var context = new PetShopDbContext();
            var dbPetShop = context.Customers.Where(customs => customs.Id == id).SingleOrDefault();
            if (dbPetShop is null)
                return;
            dbPetShop.Name = entity.Name;
            dbPetShop.Surname = entity.Surname;
            dbPetShop.Phone = entity.Phone;
            dbPetShop.Tin = entity.Tin;
            // dbPetShop.Transacts = entity.Transacts;
            context.SaveChanges();
        }
    }
}
