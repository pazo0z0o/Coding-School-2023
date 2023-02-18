using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuelStation.EF.Context;
using FuelStation.Model;

namespace FuelStation.EF.Repositories
{
    public class TransactionRepo : IEntityRepo<Transaction>
    {
        public void Add(Transaction transaction)
        {
            using var context = new FuelStationDbContext();
            context.Add(transaction);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Transaction> GetAll()
        {
            throw new NotImplementedException();
        }

        public Transaction? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Transaction transaction)
        {
            throw new NotImplementedException();
        }
    }
}
