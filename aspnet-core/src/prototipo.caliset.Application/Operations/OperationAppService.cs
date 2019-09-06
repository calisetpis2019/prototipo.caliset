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
            List<GetOperationOutput> output = Mapper.Map<List<Operation>, List<GetOperationOutput>>(getAll);
            return output;
        }

        public async Task Create(CreateOperationInput input)
        {
            var user = ObjectMapper.Map<Operation>(input);
            await _operationManager.Create(user);
        }

        public void Delete(DeleteOperationInput input)
        {
            _operationManager.Delete(input.Id);
        }

        public GetOperationOutput GetOperationById(GetOperationInput input)
        {
            var getOperation = _operationManager.GetOperationById(input.Id);
            GetOperationOutput output = Mapper.Map<Operation, GetOperationOutput>(getOperation);
            return output;
        }

        public void Update(UpdateOperationInput input)
        {
            Operation output = Mapper.Map<UpdateOperationInput, Operation>(input);
            _operationManager.Update(output);
        }
    }
}
