using IndividualPartB.Database;
using IndividualPartB.RepositoryServices;
using IndividualPartB.UserInput;
using IndividualPartB.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace IndividualPartB.Services
{
    public class AssignmentServices : IServices
    {
        private UserInputService UserInputService = new UserInputService();
        private PropertyInfo[] Properties;
        private EntityRepository EntityRepository = new EntityRepository();
        private AssignmentRepository AssignmentRepository = new AssignmentRepository();

        public void Add()
        {
            try
            {
                Assignment assignment = new Assignment();
                Properties = typeof(Assignment).GetProperties();
                UserInputService.InitializeOrUpdateEntity(Properties, assignment);
                EntityRepository.Add(assignment);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
        public void Delete()
        {
            try
            {
                EntityRepository.Delete(AssignmentRepository.Get(UserInputService.GetIdForDelete()));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }

        public void Edit()
        {
            try
            {
                Assignment assignment = new Assignment();
                Properties = typeof(Assignment).GetProperties();
                assignment.ID = UserInputService.GetIdForEdit();
                UserInputService.InitializeOrUpdateEntity(Properties, assignment);
                EntityRepository.Update(assignment, AssignmentRepository.Get);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Error()
        {
            Console.WriteLine("Wrong Choice");
        }

        public void Read()
        {
            try
            {
                PrintEntities printEntities = new PrintEntities();
                printEntities.PrintAllEntities(AssignmentRepository.GetAll());

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

      //This methods shouldnt have acces to db,
      //This method is only for prints
        public void AssignmentPerStudentPerCourseList()
        {
            using (Individual_Part_BEntities db = new Individual_Part_BEntities())
            {
                PrintEntities printEntities = new PrintEntities();
                var courses = db.Courses.ToList();
                foreach (var course in courses)
                {
                    Console.WriteLine("================================Course===============================");
                    printEntities.PrintCourse(course);
                    foreach (var student in course.Students)
                    {
                        Console.WriteLine($"================================Student===============================");
                        printEntities.PrintStudent(student);
                        Console.WriteLine($"================================Assigments===============================");
                        foreach (var assignment in student.Assignments)
                        {
                            
                            printEntities.PrintAssignment(assignment);
                        }
                    }
                }
            }

        }
    }
}
