using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyAbpProject6.Authorization;

namespace MyAbpProject6
{
    [DependsOn(
        typeof(MyAbpProject6CoreModule), 
        typeof(AbpAutoMapperModule))]
    public class MyAbpProject6ApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<MyAbpProject6AuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(MyAbpProject6ApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
