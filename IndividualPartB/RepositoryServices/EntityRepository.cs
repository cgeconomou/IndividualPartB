using IndividualPartB.Database;
using IndividualPartB.Menu.VoiceServices;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IndividualPartB.RepositoryServices
{
    public enum Entity
    {
        Student = 1,
        Trainer,
        Courses,
        Assignment
    }
    public class EntityRepository : IEntityRepository
    {
        public void Add(IEntity entity)
        {
            using (Individual_Part_BEntities db = new Individual_Part_BEntities())
            {
                db.Entry(entity).State = EntityState.Added;
                db.SaveChanges();
                VoiceGuide.VoiceMessage("The entity was succesfully added to the database");
            }
        }

        public void Delete(IEntity entityForDelete)
        {
            using (Individual_Part_BEntities db = new Individual_Part_BEntities())
            {
                if (entityForDelete != null)
                {
                    db.Entry(entityForDelete).State = EntityState.Deleted;
                    db.SaveChanges();
                    VoiceGuide.VoiceMessage("The entity was succesfully deleted");
                }
                else
                {
                    VoiceGuide.VoiceMessage("Are you sure this is the right ID?");
                    throw new Exception($"Entity does not exist...");
                }
            }
            Console.WriteLine("Deleting Entity from Database...");
        }

        public IEntity Get(int id, Func<int,IEntity> getEntity) => getEntity(id);

     
        public void Update(IEntity newEntity, Func<int, IEntity> getEntity)
        {
            using (Individual_Part_BEntities db = new Individual_Part_BEntities())
            {
                var entityForUpdate = Get(newEntity.ID, getEntity);

                if (entityForUpdate != null)
                {
                    entityForUpdate = newEntity;
                    db.Entry(entityForUpdate).State = EntityState.Modified;
                    db.SaveChanges();
                    VoiceGuide.VoiceMessage("The entity was succesfully updated");
                }
                else
                {
                    VoiceGuide.VoiceMessage("Are you sure this is the right ID?");
                    throw new Exception($"Entity does not exist...");
                }
            }
        }

    }
}
