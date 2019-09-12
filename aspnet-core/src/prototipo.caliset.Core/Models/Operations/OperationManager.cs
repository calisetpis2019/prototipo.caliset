using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.UI;
using Microsoft.EntityFrameworkCore;
using prototipo.caliset.Models.Clients;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prototipo.caliset.Models.Operations
{
    public class OperationManager:DomainService, IOperationManager
    {
        private readonly IRepository<Operation> _repositoryOperation;
        private readonly IRepository<Client> _repositoryClient;
        public OperationManager(IRepository<Operation> repositoryOperation, IRepository<Client> repositoryClient)
        {
            _repositoryOperation = repositoryOperation;
            _repositoryClient = repositoryClient;
        }

        public async Task<Operation> Create(Operation entity)
        {
            var operation = _repositoryOperation.FirstOrDefault(x => x.Id == entity.Id);
            if (operation!= null)
            {
                throw new UserFriendlyException("Already Exist");
            }
            else
            {
                entity.Client = _repositoryClient.FirstOrDefault(x => x.Id == entity.Client.Id);
                return await _repositoryOperation.InsertAsync(entity);
            }            
        }

        public void Delete(int id)
        {
            var operation = _repositoryOperation.FirstOrDefault(x => x.Id == id);
            if (operation == null)
            {
                throw new UserFriendlyException("No Data Found");
            }
            else
            {
                _repositoryOperation.Delete(operation);
            }
        }

        public IEnumerable<Operation> GetAll()
        {
            return  _repositoryOperation.GetAll()
                .Include(asset => asset.Client)
                ;
            
        }

        public   Operation GetOperationById(int id)
        {

            var List = GetAll();
            return  List.FirstOrDefault(x => x.Id == id);

            
        }

        public void Update(Operation entity)
        {
            _repositoryOperation.Update(entity);
        }
    }
}
