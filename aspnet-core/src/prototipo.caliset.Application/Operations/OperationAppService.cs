using Abp.Application.Services;
using AutoMapper;
using prototipo.caliset.Models.Operations;
using prototipo.caliset.Operations.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototipo.caliset.Operations
{
    public class OperationAppService : ApplicationService, IOperationAppService
    {
        private readonly IOperationManager _operationManager;
        public OperationAppService(IOperationManager operationManager)
        {
            _operationManager = operationManager;
        }

        public IEnumerable<GetOperationOutput> All()
        {
            var getAll = _operationManager.GetAll().ToList();
            List<GetOperationOutput> output = ObjectMapper.Map<List<GetOperationOutput>>(getAll);
            return output;
        }

        public async Task Create(CreateOperationInput input)
        {
            var operation = ObjectMapper.Map<Operation>(input);
            await _operationManager.Create(operation);
        }

        public void Delete(DeleteOperationInput input)
        {
            _operationManager.Delete(input.Id);
        }

        public GetOperationOutput GetOperationById(GetOperationInput input)
        {
            var getOperation = _operationManager.GetOperationById(input.Id);
            GetOperationOutput output = ObjectMapper.Map<GetOperationOutput>(getOperation);
            return output;
        }

        public void Update(UpdateOperationInput input)
        {
            var operation = _operationManager.GetOperationById(input.Id);
            _operationManager.Update(operation);
        }
    }
}
