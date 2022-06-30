using IndividualPartB.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualPartB.RepositoryServices
{
    public  class StudentRepository : IRepository
    {
        
        public  IEntity Get(int id)
        {
            using (Individual_Part_BEntities db = new Individual_Part_BEntities())
            {
                var student = db.Students.Find(id);
                return student;
            }
        }
       
        public  List<IEntity> GetAll()
        {
           
            using (Individual_Part_BEntities db = new Individual_Part_BEntities())
            {
                List<Student> students = db.Students.ToList();
                List<IEntity> entitiesStudents = new List<IEntity>();
                foreach (var stu in students)
                {
                    entitiesStudents.Add(stu);
                }
                return entitiesStudents;
            }
        }
    }

    
}
