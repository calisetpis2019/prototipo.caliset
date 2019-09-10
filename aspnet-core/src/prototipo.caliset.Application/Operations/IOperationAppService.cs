using Abp.Application.Services;
using prototipo.caliset.Operations.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace prototipo.caliset.Operations
{
    public interface IOperationAppService : IApplicationService
    {
        IEnumerable<GetOperationOutput> GetAll();
        Task Create(CreateOperationInput input);
        void Update(UpdateOperationInput input);
        void Delete(DeleteOperationInput input);
        GetOperationOutput GetOperationById(GetOperationInput input);

    }
}
