using IndividualPartB.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualPartB.Views
{
    public class PrintEntities
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entities"></param>
        public void Print(IEntity entities)
        {
            Console.WriteLine(entities);
        }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="entities"></param>
        
        public void PrintAllEntities(List<IEntity> entities)
        {
            if (entities[0] is Student)
            {
                Console.WriteLine($"{"ID",-5}{"FirstName",-15}{"LasstName",-15}{"DateOfBirth",-30}{"Tuition Fees",-15}");
                foreach (var ent in entities)
                {
                    PrintStudent((Student)ent);
                }
            }
            if (entities[0] is Trainer)
            {
                Console.WriteLine($"{"ID",-15}{"FirstName",-15}{"LasstName",-15}{"Subject",-30}");
                foreach (var ent in entities)
                {
                    PrintTrainer((Trainer)ent);
                }
            }
            if (entities[0] is Course)
            {
                Console.WriteLine($"{"ID",-15}{"Tittle",-15}{"Type",-15}{"Stream",-30}");
                foreach (var ent in entities)
                {
                    PrintCourse((Course)ent);
                }
            }
            if (entities[0] is Assignment)
            {
                Console.WriteLine($"{"ID",-15}{"Tittle",-15}{"Description",-15}");
                foreach (var ent in entities)
                {
                    PrintAssignment((Assignment)ent);
                }
            }

            
        }
        public void PrintStudent(Student student)=> Console.WriteLine($"{student.ID,-5}{student.FirstName,-15}{student.LastName,-15}{student.DateOfBirth.ToString(),-30}{student.TuitionFees,-15}");
       
        public void PrintTrainer(Trainer trainer)=> Console.WriteLine($"{trainer.ID,-15}{trainer.FirstName,-15}{trainer.LastName,-15}{trainer.Subject,-30}");

        public void PrintCourse(Course course) => Console.WriteLine($"{course.ID,-15}{course.Title,-15}{course.Type,-15}{course.Stream,-30}");
        public void PrintAssignment(Assignment assignment) => Console.WriteLine($"{assignment.ID,-15}{assignment.Title,-15}{assignment.Description,-15}");
        



    }
}
