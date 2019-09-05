using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Abp.Authorization.Users;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace Entities.Operations
{
   public class Operation<TUser> : OperationDB, IFullAudited<TUser>, IAudited<TUser>, IAudited, ICreationAudited, IHasCreationTime, IModificationAudited, IHasModificationTime, ICreationAudited<TUser>, IModificationAudited<TUser>, IFullAudited, IDeletionAudited, IHasDeletionTime, ISoftDelete, IDeletionAudited<TUser> where TUser : AbpUser<TUser>
    {
        public const int MaxConcurrencyStampLength = 128;

        public Operation() { }
               
        //
        // Resumen:
        //     A random value that must change whenever a user is persisted to the store
        [StringLength(128)]
        public virtual string ConcurrencyStamp { get; set; }
        public virtual TUser DeleterUser { get; set; }
        public virtual TUser CreatorUser { get; set; }
        public virtual TUser LastModifierUser { get; set; }

    }
}