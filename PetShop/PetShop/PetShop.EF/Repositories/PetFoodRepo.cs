﻿using PetShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.EF.Repositories
{//TODO: Implement PetFoodRepo
    public class PetFoodRepo : IEntityRepo<PetFood>
    {
        public void Add(PetFood entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<PetFood> GetAll()
        {
            throw new NotImplementedException();
        }

        public PetFood? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, PetFood entity)
        {
            throw new NotImplementedException();
        }
    }
}
