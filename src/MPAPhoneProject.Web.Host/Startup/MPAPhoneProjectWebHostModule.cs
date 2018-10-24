using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MPAPhoneProject.Configuration;

namespace MPAPhoneProject.Web.Host.Startup
{
    [DependsOn(
       typeof(MPAPhoneProjectWebCoreModule))]
    public class MPAPhoneProjectWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public MPAPhoneProjectWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MPAPhoneProjectWebHostModule).GetAssembly());
        }
    }
}
