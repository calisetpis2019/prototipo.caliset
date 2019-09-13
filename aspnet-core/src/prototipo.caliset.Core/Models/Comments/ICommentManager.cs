using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace prototipo.caliset.Models.Comments
{
    public interface ICommentManager: IDomainService
    {
        IEnumerable<Comment> GetAll();
        Comment GetCommentById(int id);
        Task<Comment> Create(Comment entity);
        void Update(Comment entity);
        void Delete(int id);
    }
}
