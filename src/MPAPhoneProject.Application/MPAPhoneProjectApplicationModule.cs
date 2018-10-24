using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MPAPhoneProject.Authorization;

namespace MPAPhoneProject
{
    [DependsOn(
        typeof(MPAPhoneProjectCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class MPAPhoneProjectApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<MPAPhoneProjectAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(MPAPhoneProjectApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
