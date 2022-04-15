using EstateManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateManagement.Repository.JsonRepository
{
    //implementare folosind fisiere json pe disk
    internal class EstateRepository : IRepository<Estate>
    {
        public Estate Create(Estate value)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteName(string pictures)
        {
            throw new NotImplementedException();
        }

        public List<Estate> GetAll()
        {
            throw new NotImplementedException();
        }

        public Estate GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Estate Update(Estate value)
        {
            throw new NotImplementedException();
        }
    }
}
