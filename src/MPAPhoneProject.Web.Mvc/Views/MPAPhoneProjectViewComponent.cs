using Abp.AspNetCore.Mvc.ViewComponents;

namespace MPAPhoneProject.Web.Views
{
    public abstract class MPAPhoneProjectViewComponent : AbpViewComponent
    {
        protected MPAPhoneProjectViewComponent()
        {
            LocalizationSourceName = MPAPhoneProjectConsts.LocalizationSourceName;
        }
    }
}
