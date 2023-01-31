using Microsoft.EntityFrameworkCore;
using Session_16.EF.Models;
using Session_16.EF.PetShop.Orm.Context;
using Session16.EF.PetShop.Orm.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_16.EF.PetShop.Orm.Repositories
{
    public class CustomersRepo : IEntity<Customers>
    {
        public void Add(Customers entity)
        {
            using var context = new AppDbContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            using var context = new AppDbContext();
            var dbPetShop = context.Customs.Where(customs => customs.CustomerID == id).SingleOrDefault();
            if (dbPetShop is null)
                return;
            context.Remove(dbPetShop);
            context.SaveChanges();

        }

       

        public IList<Customers> GetAll()
        {
            using var context = new AppDbContext();
            return context.Customs.Include(customs => customs.Transacts).ToList();
        }

        public Customers? GetById(Guid id)
        {
            using var context = new AppDbContext();
            return context.Customs.Where(customs => customs.CustomerID == id).Include(customs => customs.Transacts).SingleOrDefault();
                
        }

        public void Update(Guid id, Customers entity)
        {
            using var context = new AppDbContext();
            var dbPetShop = context.Customs.Where(customs => customs.CustomerID == id).SingleOrDefault();
            if (dbPetShop is null)
                return;
            dbPetShop.Name = entity.Name;
            dbPetShop.Surname = entity.Surname;
            dbPetShop.Phone = entity.Phone;
            dbPetShop.TIN = entity.TIN;
            dbPetShop.Transacts = entity.Transacts;
            context.SaveChanges();

        }

       
    }
}
