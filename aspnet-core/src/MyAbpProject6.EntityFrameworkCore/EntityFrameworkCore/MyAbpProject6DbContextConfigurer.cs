using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace MyAbpProject6.EntityFrameworkCore
{
    public static class MyAbpProject6DbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<MyAbpProject6DbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<MyAbpProject6DbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
