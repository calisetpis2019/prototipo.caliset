using Abp.Domain.Services;
using prototipo.caliset.Models.Comments;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace prototipo.caliset.Models.Operations
{
    public interface IOperationManager:IDomainService
    {
        IEnumerable<Operation> GetAll();
        Operation GetOperationById(int id);
        Task<Operation> Create(Operation entity);
        void Update(Operation entity);
        void Delete(int id);
        IEnumerable<Comment> GetComments(int id);
        void AddComent(int id, Comment cmm);
    }
}
