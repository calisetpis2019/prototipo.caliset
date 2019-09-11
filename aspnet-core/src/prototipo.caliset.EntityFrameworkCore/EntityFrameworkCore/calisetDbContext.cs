using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using prototipo.caliset.Authorization.Roles;
using prototipo.caliset.Authorization.Users;
using prototipo.caliset.MultiTenancy;

namespace prototipo.caliset.EntityFrameworkCore
{
    public class calisetDbContext : AbpZeroDbContext<Tenant, Role, User, calisetDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public calisetDbContext(DbContextOptions<calisetDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Models.Operations.Operation> Operation { get; set; }
        public virtual DbSet<Models.Clients.Client> Client { get; set; }
    }
}
