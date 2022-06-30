using IndividualPartB.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualPartB.RepositoryServices
{
    public class AssignmentRepository : IRepository
    {
        public  IEntity Get(int id)
        {
            using (Individual_Part_BEntities db = new Individual_Part_BEntities())
            {
                var assignment = db.Assignments.Find(id);
                return assignment;
            }
        }

        public List<IEntity> GetAll()
        {
            using (Individual_Part_BEntities db = new Individual_Part_BEntities())
            {
                List<Assignment> assignments = db.Assignments.ToList();
                List<IEntity> entitiesAssignments = new List<IEntity>();
                foreach (var ass in assignments)
                {
                    entitiesAssignments.Add(ass);
                }
                return entitiesAssignments;
            }
        }
    }
}
