using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace prototipo.caliset.Controllers
{
    public abstract class calisetControllerBase: AbpController
    {
        protected calisetControllerBase()
        {
            LocalizationSourceName = calisetConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
