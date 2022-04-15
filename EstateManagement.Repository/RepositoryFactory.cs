using EstateManagement.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateManagement.Repository
{
    public class RepositoryFactory
    {
        public static IRepository<Estate> CreateEstateRepository()
        {
            //obtine repository type (1 sau 2) din app.config
         var repType = 1;
            //var repType = Convert.ToInt32(ConfigurationManager.AppSettings["repType"]);
            
            switch (repType) 
            {
                case (int)RepositoryType.Sql: return new EstateManagement.Repository.SqlRepository.EstateRepository();
                case (int)RepositoryType.Json: return new EstateManagement.Repository.JsonRepository.EstateRepository();
            }
               
            //default
            return new EstateManagement.Repository.SqlRepository.EstateRepository();
        }

        public static IRepository<Picture> CreatePictureRepository()
        {
            return new EstateManagement.Repository.SqlRepository.PictureRepository();
        }

        public static IRepository<Owner> CreateOwnerRepository()
        {
            return new EstateManagement.Repository.SqlRepository.OwnerRepository();
        }
    }
}
