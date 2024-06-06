using GlobalSolutionAdmin.BusinessLogic.Interfaces.Repositories;
using GlobalSolutionAdmin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalSolutionAdmin.DataAccess.Client
{
    public class ClientRepository: IClientRepository
    {
        private readonly GlobalSolutionEntities _datacontext;

        public ClientRepository(GlobalSolutionEntities datacontext)
        {
            _datacontext=datacontext;
        }

        public Models.Client Create(Models.Client client)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Models.Client> GetAll()
        {
            throw new NotImplementedException();
        }

        public Models.Client GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Models.Client Update(Models.Client client)
        {
            throw new NotImplementedException();
        }
    }
}
