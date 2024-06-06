using GlobalSolutionAdmin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalSolutionAdmin.BusinessLogic.Interfaces.Repositories
{
    public interface IClientRepository
    {
        Client Create(Client client);
        Client GetById(int id);
        IEnumerable<Client> GetAll();
        Client Update(Client client);
        bool Delete(int id);
    }
}
