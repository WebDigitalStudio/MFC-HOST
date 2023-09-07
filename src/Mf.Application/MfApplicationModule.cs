using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Mf.Authorization;

namespace Mf
{
    [DependsOn(
        typeof(MfCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class MfApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<MfAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(MfApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
