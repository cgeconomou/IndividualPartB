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
    internal class TrainerServices : IServices
    {
        private UserInputService UserInputService = new UserInputService();
        private PropertyInfo[] Properties;
        private EntityRepository EntityRepository = new EntityRepository();
        private TrainerRepository TrainerRepository = new TrainerRepository();
        
        public void Add()
        {
            try
            {
                Trainer trainer = new Trainer();
                Properties = typeof(Trainer).GetProperties();
                UserInputService.InitializeOrUpdateEntity(Properties, trainer);
                EntityRepository.Add(trainer);
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
                EntityRepository.Delete(TrainerRepository.Get(UserInputService.GetIdForDelete()));
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
                Trainer trainer = new Trainer();
                Properties = typeof(Trainer).GetProperties();
                trainer.ID = UserInputService.GetIdForEdit();
                UserInputService.InitializeOrUpdateEntity(Properties, trainer);
                EntityRepository.Update(trainer, TrainerRepository.Get);
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
                printEntities.PrintAllEntities(TrainerRepository.GetAll());
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
        
        public void TrainerPerCourseList()
        {
            using (Individual_Part_BEntities db = new Individual_Part_BEntities())
            {
                PrintEntities printEntities = new PrintEntities();
               var courses = db.Courses.ToList();
                foreach (var course in courses)
                {
                    Console.WriteLine("================================Course===============================");
                    printEntities.PrintCourse(course);
                    foreach (var trainer in course.Trainers)
                    {
                        printEntities.PrintTrainer(trainer);
                    }
                }
            }
            
        }
    }
}

