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
    public class TransactionLinesRepo : IEntityRepo<TransactionLine>
    {
        public void Add(TransactionLine entity)
        {
            using var context = new PetShopDbContext();
            context.TransactionLines.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new PetShopDbContext();
            var dbTransLine = context.TransactionLines.Where(tl=> tl.Id == id).SingleOrDefault();
            if (dbTransLine == null)
            {
                throw new Exception($"Transaction Line with id: {id} not found ");
                return;
            }
            context.Remove(dbTransLine);
            context.SaveChanges();
        }

        public IList<TransactionLine> GetAll()
        {
            throw new NotImplementedException();
        }

        public TransactionLine? GetById(int id)
        {
            using var context = new PetShopDbContext();
            return context.TransactionLines.Where(t => t.Id == id).Include(t => t.Pet).Include(t => t.PetFood).SingleOrDefault();
        }

        public void Update(int id, TransactionLine entity)
        {
            throw new NotImplementedException();
        }
    }
}
