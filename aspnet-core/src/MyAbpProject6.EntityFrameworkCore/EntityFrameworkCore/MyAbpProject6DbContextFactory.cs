using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using MyAbpProject6.Configuration;
using MyAbpProject6.Web;

namespace MyAbpProject6.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class MyAbpProject6DbContextFactory : IDesignTimeDbContextFactory<MyAbpProject6DbContext>
    {
        public MyAbpProject6DbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<MyAbpProject6DbContext>();
            
            /*
             You can provide an environmentName parameter to the AppConfigurations.Get method. 
             In this case, AppConfigurations will try to read appsettings.{environmentName}.json.
             Use Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") method or from string[] args to get environment if necessary.
             https://docs.microsoft.com/en-us/ef/core/cli/dbcontext-creation?tabs=dotnet-core-cli#args
             */
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            MyAbpProject6DbContextConfigurer.Configure(builder, configuration.GetConnectionString(MyAbpProject6Consts.ConnectionStringName));

            return new MyAbpProject6DbContext(builder.Options);
        }
    }
}
