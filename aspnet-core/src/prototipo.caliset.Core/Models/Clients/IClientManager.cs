using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace prototipo.caliset.Models.Clients
{
    public interface IClientManager: IDomainService
    {
        IEnumerable<Client> GetAll();
        Client GetClientById(int id);
        Task<Client> Create(Client entity);
        void Update(Client entity);
        void Delete(int id);
    }
}
