using PetShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.EF.Repositories
{//TODO: Implement TransactionRepo
    public class TransactionRepo : IEntityRepo<Transaction>
    {
        public void Add(Transaction entity)
        {
            throw new NotImplementedException();
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

        public void Update(int id, Transaction entity)
        {
            throw new NotImplementedException();
        }
    }
}
