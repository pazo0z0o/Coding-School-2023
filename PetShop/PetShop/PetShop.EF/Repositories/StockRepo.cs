using PetShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.EF.Repositories
{
    public class StockRepo : IEntityRepo<Stock>
    { //TODO: implement Repo for Stock
        public void Add(Stock entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Stock> GetAll()
        {
            throw new NotImplementedException();
        }

        public Stock? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Stock entity)
        {
            throw new NotImplementedException();
        }
    }
}
