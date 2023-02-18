using FuelStation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuelStation.EF.Context;

namespace FuelStation.EF.Repositories
{
    public class ItemRepo : IEntityRepo<Item>
    {
        public void Add(Item item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Item> GetAll()
        {
            throw new NotImplementedException();
        }

        public Item? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Item item)
        {
            throw new NotImplementedException();
        }
    }
}
