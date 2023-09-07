using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Mf.Controllers
{
    public abstract class MfControllerBase: AbpController
    {
        protected MfControllerBase()
        {
            LocalizationSourceName = MfConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
