using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Mf.EntityFrameworkCore;
using Mf.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Mf.Web.Tests
{
    [DependsOn(
        typeof(MfWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class MfWebTestModule : AbpModule
    {
        public MfWebTestModule(MfEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MfWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(MfWebMvcModule).Assembly);
        }
    }
}