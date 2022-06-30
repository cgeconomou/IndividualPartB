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
    internal class CourseServices : IServices
    {
        private UserInputService UserInputService = new UserInputService();
        private PropertyInfo[] Properties;
        private EntityRepository EntityRepository = new EntityRepository();
        private CourseRepository CourseRepository = new CourseRepository();
       
        public void Add()
        {
            try
            {
                Course course = new Course();
                Properties = typeof(Course).GetProperties();
                UserInputService.InitializeOrUpdateEntity(Properties, course);
                EntityRepository.Add(course);
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
                EntityRepository.Delete(CourseRepository.Get(UserInputService.GetIdForDelete()));
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
                Course course = new Course();
                Properties = typeof(Course).GetProperties();
                course.ID = UserInputService.GetIdForEdit();
                UserInputService.InitializeOrUpdateEntity(Properties, course);
                EntityRepository.Update(course, CourseRepository.Get);
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
                printEntities.PrintAllEntities(CourseRepository.GetAll());
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
