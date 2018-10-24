using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace MPAPhoneProject.Controllers
{
    public abstract class MPAPhoneProjectControllerBase: AbpController
    {
        protected MPAPhoneProjectControllerBase()
        {
            LocalizationSourceName = MPAPhoneProjectConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
