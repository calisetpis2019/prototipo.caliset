using Abp.MultiTenancy;
using prototipo.caliset.Authorization.Users;

namespace prototipo.caliset.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
