using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MPAPhoneProject.Configuration;

namespace MPAPhoneProject.Web.Startup
{
    [DependsOn(typeof(MPAPhoneProjectWebCoreModule))]
    public class MPAPhoneProjectWebMvcModule : AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public MPAPhoneProjectWebMvcModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {
            Configuration.Navigation.Providers.Add<MPAPhoneProjectNavigationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MPAPhoneProjectWebMvcModule).GetAssembly());
        }
    }
}
