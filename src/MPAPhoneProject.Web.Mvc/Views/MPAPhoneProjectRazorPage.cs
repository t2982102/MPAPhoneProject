using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace MPAPhoneProject.Web.Views
{
    public abstract class MPAPhoneProjectRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected MPAPhoneProjectRazorPage()
        {
            LocalizationSourceName = MPAPhoneProjectConsts.LocalizationSourceName;
        }
    }
}
