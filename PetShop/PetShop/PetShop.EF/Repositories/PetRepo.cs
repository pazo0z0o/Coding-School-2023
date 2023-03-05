using PetShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.EF.Repositories
{//TODO: Implement PetRepo
    public class PetRepo : IEntityRepo<Pet>
    {
        public void Add(Pet entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Pet> GetAll()
        {
            throw new NotImplementedException();
        }

        public Pet? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Pet entity)
        {
            throw new NotImplementedException();
        }
    }
}
