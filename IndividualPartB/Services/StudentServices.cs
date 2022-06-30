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
using System.Data.Entity;

namespace IndividualPartB.Services
{
    public class StudentServices : IServices
    {
        private UserInputService UserInputService = new UserInputService();
        private PropertyInfo[] Properties;
        private EntityRepository EntityRepository = new EntityRepository();
        private StudentRepository StudentRepository = new StudentRepository();
        
        public void Add()
        {
            try
            {
                
                Student student = new Student();
                Properties = typeof(Student).GetProperties();
                UserInputService.InitializeOrUpdateEntity(Properties, student);
                EntityRepository.Add(student);
              
                
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
                EntityRepository.Delete(StudentRepository.Get(UserInputService.GetIdForDelete()));
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
                Student student = new Student();
                Properties = typeof(Student).GetProperties();
                student.ID = UserInputService.GetIdForEdit();
                UserInputService.InitializeOrUpdateEntity(Properties, student);
                EntityRepository.Update(student, StudentRepository.Get);
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
                printEntities.PrintAllEntities(StudentRepository.GetAll());
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        public void StudentPerCourseList()
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
                        printEntities.PrintStudent(student);    
                    }
                }
            }
           
        }
    }
}
