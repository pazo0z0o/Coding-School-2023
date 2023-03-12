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

        public void Delete(int id)
        {
           
        }

        public IList<Transaction> GetAll()
        {
            using var context = new PetShopDbContext();
            return context.Transactions.Include(transaction => transaction.Customer)
            .Include(transaction => transaction.Employee)
            .ToList();
           
        }

        public Transaction? GetById(int id)
        {
            using var context = new PetShopDbContext();
            return context.Transactions.Where(transaction=>transaction.Id == id)
           .Include(transaction => transaction.Customer)
           .Include(transaction => transaction.Employee)
           .SingleOrDefault();
        }

        public void Update(int id, Transaction entity)
        {
            using var context = new PetShopDbContext();
            var TransactionDb = context.Transactions
                .Where(tr => tr.Id == id)
                .SingleOrDefault();
            if (TransactionDb is null)
            { throw new KeyNotFoundException($"Given id '{id}' was not found");
                return;
            }
            TransactionDb.TotalPrice = entity.TotalPrice;
            context.SaveChanges();
        }
    }
}
