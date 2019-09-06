using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.UI;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace prototipo.caliset.Models.Operations
{
    public class OperationManager:DomainService, IOperationManager
    {
        private readonly IRepository<Operation> _repositoryOperation;
        public OperationManager(IRepository<Operation> repositoryOperation)
        {
            _repositoryOperation = repositoryOperation;
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
            return _repositoryOperation.GetAll();
        }

        public Operation GetOperationById(int id)
        {
            return _repositoryOperation.Get(id);
        }

        public void Update(Operation entity)
        {
            _repositoryOperation.Update(entity);
        }
    }
}
