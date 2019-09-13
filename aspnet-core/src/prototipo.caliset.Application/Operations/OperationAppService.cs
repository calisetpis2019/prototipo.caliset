using Abp.Application.Services;
using AutoMapper;
using prototipo.caliset.Comments.Dto;
using prototipo.caliset.Models.Comments;
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
        private readonly ICommentManager _commentManager;
        public OperationAppService(IOperationManager operationManager, ICommentManager commentManager)
        {
            _operationManager = operationManager;
            _commentManager = commentManager;

        }

        public IEnumerable<GetOperationOutput> GetAll()
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
            //NO MODIFICA EL CLIENTE
        {
            var operation = _operationManager.GetOperationById(input.Id);
            operation.Commodity = input.Commodity;
            operation.Destiny = input.Destiny;
            operation.Date = input.Date;

            _operationManager.Update(operation);
        }

        public IEnumerable<GetCommentOutput> GetOperationAllComments(GetOperationInput input)
        {
            var getComments = _operationManager.GetOperationById(input.Id);
            var CmmRet = getComments.Comments.ToList();
            List<GetCommentOutput> output = ObjectMapper.Map<List<GetCommentOutput>>(CmmRet) ;
            return output;
        }

        public async Task AddComment(GetOperationInput OpInput, CreateCommentInput input)
        {
            var cmm = ObjectMapper.Map<Comment>(input);
            _operationManager.AddComent(OpInput.Id, cmm);
           await _commentManager.Create(cmm);
        }
    }
}
