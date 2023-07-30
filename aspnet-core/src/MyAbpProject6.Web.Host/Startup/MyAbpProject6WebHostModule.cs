using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyAbpProject6.Configuration;

namespace MyAbpProject6.Web.Host.Startup
{
    [DependsOn(
       typeof(MyAbpProject6WebCoreModule))]
    public class MyAbpProject6WebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public MyAbpProject6WebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyAbpProject6WebHostModule).GetAssembly());
        }
    }
}
