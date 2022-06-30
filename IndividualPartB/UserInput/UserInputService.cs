using IndividualPartB.Database;
using IndividualPartB.ValidationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace IndividualPartB.UserInput
{

    public class UserInputService
    {
        /// <summary>
        ///  The method InitializeOrUpdateEntity() uses an object from PropertyInfo to
        ///  check what types are the properties of an object and then using the method
        ///  SetValue() to set the properties value of the object our method took as a 
        ///  parameter.
        /// </summary>
        /// <param name="properties">IEntity</param>
        /// <param name="entity">PropertyInfo using  System.Reflection</param>
        public void InitializeOrUpdateEntity(PropertyInfo[] properties, IEntity entity)
        {
            for (int i = 0; i < properties.Length; i++)
            {
                var property = properties[i];
                if (property.PropertyType == typeof(String))
                {
                    Console.WriteLine($" give me {property.Name} of the {(entity.GetType()).Name}");
                    property.SetValue(entity, Validate.Strings(Console.ReadLine()));
                }
                else if (property.PropertyType == typeof(Int32?) && (property.Name != "ID"))
                {
                    Console.WriteLine($" give me {property.Name} of the {(entity.GetType()).Name}");
                    property.SetValue(entity, Validate.Integer(Console.ReadLine()));
                }
                else if (property.PropertyType == typeof(DateTime?))
                {
                    Console.WriteLine($" give me {property.Name} of the {(entity.GetType()).Name}");
                    property.SetValue(entity, Validate.Date(Console.ReadLine()));
                }
                else if (property.PropertyType == typeof(Double))
                {
                    Console.WriteLine($" give me {property.Name} of the {(entity.GetType()).Name}");
                    property.SetValue(entity, Validate.Doubles(Console.ReadLine()));
                }
                else if (property.PropertyType == typeof(ICollection<Course>))
                {
                    Console.WriteLine($"Would you like to add this {(entity.GetType()).Name} an existing Course? ");
                    Console.WriteLine("--------doesnt work yet-----------------");
                }
                else
                {
                    Console.WriteLine($"The {properties[i].Name} cant be filled manually");
                }
            }
        }



        /// <summary>
        ///  The method GetIdForDelete() ask the user to type the id of the 
        ///  entity he wants to delete. It checks if the input is in the right
        ///  format using the Integer() method for Validate class and then returns
        ///  the id.
        /// </summary>
        /// <returns></returns>
        public int GetIdForDelete()
        {
            Console.WriteLine("Give the id of the Entity you wish to delete");
            int id = Validate.Integer(Console.ReadLine());
            return id;
        }
        /// <summary>
        ///  The method GetIdForCourse() ask the user to type the id of the 
        ///  Course he wants to add in a Student.It checks if the input is in the right
        ///  format using the Integer() method for Validate class and then returns
        ///  the id.
        /// </summary>
        /// <returns></returns>
        public int GetIdForCourse()
        {
            Console.WriteLine("Give the id of the Course you want to add");
            int id = Validate.Integer(Console.ReadLine());
            return id;
        }
        public int GetIdForEdit()
        {
            Console.WriteLine("Give the id of the Entity you want to edit");
            int id = Validate.Integer(Console.ReadLine());
            return id;
        }
        



    }
}
