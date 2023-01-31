using Session_16.EF.Models;
using Session_16.EF.PetShop.Orm.Context;
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
            var dbTodo = context.Customs.Where(customs => customs.CustomerID == id).SingleOrDefault();
            if (dbTodo is null)
                return;
            context.Remove(dbTodo);
            context.SaveChanges();

        }

       

        public IList<Customers> GetAll()
        {
            throw new NotImplementedException();
        }

        public Customers? GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Guid id, Customers entity)
        {
            throw new NotImplementedException();
        }

        /* public IList<Customers> GetAll()
         {

         }

         public Customers? GetById(int id)
         {

         }

         public void Update(int id, Customers entity)
         {

         }*/
    }
}
