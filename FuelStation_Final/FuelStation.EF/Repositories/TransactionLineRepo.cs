using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuelStation.EF.Context;
using FuelStation.Model;

namespace FuelStation.EF.Repositories
{
    public class TransactionLineRepo : IEntityRepo<TransactionLine>
    {
        public void Add(TransactionLine tline)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<TransactionLine> GetAll()
        {
            throw new NotImplementedException();
        }

        public TransactionLine? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, TransactionLine tline)
        {
            throw new NotImplementedException();
        }
    }
}
