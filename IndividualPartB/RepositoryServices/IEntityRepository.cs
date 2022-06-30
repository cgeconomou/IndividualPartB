using IndividualPartB.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualPartB.RepositoryServices
{
    interface IEntityRepository
    {
       
        IEntity Get(int id, Func<int, IEntity> getEntity);
        
        void Delete(IEntity entity);
        
        void Update(IEntity newEntity, Func<int, IEntity> getEntity);
       
        void Add(IEntity entity);
    }
}
