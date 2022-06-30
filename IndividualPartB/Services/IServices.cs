using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualPartB.Services
{
     interface IServices
    {
        /// <summary>
        ///  The method Read() is printing a list of entities in Console
        ///  using the method PrintAllEntities().
        /// </summary>
        void Read();
        /// <summary>
        /// The Add() method in IServices adds a specific element into a collection. The method 
        /// here is getting the properties through the GetProperties() method and then 
        /// through the InitializeOrUpdateEntity() method creates the entity.Then through the 
        /// method Add() from IEntityRepository adds the element to the repository.
        /// </summary>
        void Add();
        /// <summary>
        ///  The Edit() method in IServices eddit a specific element into a collection. The method
        /// here is getting the properties through the GetProperties() method and then 
        /// through the InitializeOrUpdateEntity() method updates the entity.
        /// </summary>
        void Edit();
        /// <summary>
        /// The Delete() method in IServices deletes a specific element into a collection. The method
        /// here is using the Delete() method from  IEntityRepository.
        /// </summary>
        void Delete();

        /// <summary>
        ///  You dont need a description for this method!!!
        /// </summary>
        void Error();
    }
}
