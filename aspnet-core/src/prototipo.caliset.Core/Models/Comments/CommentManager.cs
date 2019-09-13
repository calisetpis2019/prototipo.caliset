using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.UI;
using Microsoft.EntityFrameworkCore;
using prototipo.caliset.Authorization.Users;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace prototipo.caliset.Models.Comments
{
    public class CommentManager : DomainService, ICommentManager
    {

        private readonly IRepository<Comment> _repositoryComment;
        public CommentManager(IRepository<Comment> repositoryComment )
        {
            _repositoryComment = repositoryComment;
        }

        public async Task<Comment> Create(Comment entity)
        {
            var cmm = _repositoryComment.FirstOrDefault(x => x.Id == entity.Id);
            if (cmm != null)
            {
                throw new UserFriendlyException("Already Exist");
            }
            else
            {
                //Falta insertar el usuario que comenta aca para que se asocie al comentario
                return await _repositoryComment.InsertAsync(entity);
            }
        }

        public void Delete(int id)
        {
            var cmm = _repositoryComment.FirstOrDefault(x => x.Id == id);
            if (cmm == null)
            {
                throw new UserFriendlyException("No Data Found");
            }
            else
            {
                _repositoryComment.Delete(cmm);
            }
        }

        public IEnumerable<Comment> GetAll()
        {
            return _repositoryComment.GetAll();
                //.Include(x => x.User) ; 
        }

        public Comment GetCommentById(int id)
        {
            return _repositoryComment.Get(id);
        }

        public void Update(Comment entity)
        {
            _repositoryComment.Update(entity);
        }
    }
}
