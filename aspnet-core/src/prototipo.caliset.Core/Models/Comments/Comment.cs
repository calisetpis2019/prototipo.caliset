using Abp.Domain.Entities.Auditing;
using prototipo.caliset.Authorization.Users;
using prototipo.caliset.Models.Operations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace prototipo.caliset.Models.Comments
{
    [Table("Comments")]
    public class Comment : FullAuditedEntity
    {
        protected Comment() { }
    
        //public virtual User User { get; set; }
        public string Commentary { get; set; }
    }
}
