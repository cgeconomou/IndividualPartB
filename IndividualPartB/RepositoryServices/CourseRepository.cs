using IndividualPartB.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualPartB.RepositoryServices
{
    public class CourseRepository: IRepository
    {
        public  IEntity Get(int id)
        {
            using (Individual_Part_BEntities db = new Individual_Part_BEntities())
            {
                var course = db.Courses.Find(id);
                return course;
            }
        }

        public List<IEntity> GetAll()
        {
            using (Individual_Part_BEntities db = new Individual_Part_BEntities())
            {
                List<Course> courses = db.Courses.ToList();
                List<IEntity> entitiesCourses = new List<IEntity>();
                foreach (var cou in courses)
                {
                    entitiesCourses.Add(cou);
                }
                return entitiesCourses;
            }
        }
    }
}
