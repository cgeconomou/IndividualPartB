using IndividualPartB.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualPartB.RepositoryServices
{
    interface IRepository
    {
        /// <summary>
        /// This method Get() ask an Id from database,and return 
        /// the IEntity if the IEntity exist in database
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        IEntity Get(int id);
    }
}
