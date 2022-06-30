using IndividualPartB.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualPartB.RepositoryServices
{
    public class TrainerRepository : IRepository
    {
        
        public  IEntity Get(int id)
        {
            using (Individual_Part_BEntities db = new Individual_Part_BEntities())
            {
                var trainer = db.Trainers.Find(id);
                return trainer;
            }
        }
        
        public List<IEntity> GetAll()
        {
            using (Individual_Part_BEntities db = new Individual_Part_BEntities())
            {
                List<Trainer> trainers = db.Trainers.ToList();
                List<IEntity> entitiesTrainers = new List<IEntity>();
                foreach (var tra in trainers)
                {
                    entitiesTrainers.Add(tra);
                }
                return entitiesTrainers;
            }

        }
      
    }
}
