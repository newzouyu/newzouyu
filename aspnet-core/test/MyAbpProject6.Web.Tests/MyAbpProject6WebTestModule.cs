using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyAbpProject6.EntityFrameworkCore;
using MyAbpProject6.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace MyAbpProject6.Web.Tests
{
    [DependsOn(
        typeof(MyAbpProject6WebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class MyAbpProject6WebTestModule : AbpModule
    {
        public MyAbpProject6WebTestModule(MyAbpProject6EntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyAbpProject6WebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(MyAbpProject6WebMvcModule).Assembly);
        }
    }
}