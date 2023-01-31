using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_16.EF.PetShop.Orm.Repositories
{
    public interface IEntity<TEntity>
    { 
        IList<TEntity> GetAll();
        TEntity? GetById(Guid id);
        void Add(TEntity entity);
        void Update(Guid id, TEntity entity);
        void Delete(Guid id);


    }
}
