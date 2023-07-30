using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MyAbpProject6.Authorization.Roles;
using MyAbpProject6.Authorization.Users;
using MyAbpProject6.MultiTenancy;
using MyAbpProject6.PhoneBooks.Persons;
using MyAbpProject6.PhoneBooks.PhoneNumbers;


namespace MyAbpProject6.EntityFrameworkCore
{
    public class MyAbpProject6DbContext : AbpZeroDbContext<Tenant, Role, User, MyAbpProject6DbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public MyAbpProject6DbContext(DbContextOptions<MyAbpProject6DbContext> options)
            : base(options)
        {

        }

        public DbSet<Person> Person { get; set; }

        public DbSet<PhoneNumber> PhoneNumber { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().ToTable("Person", "PB");
            modelBuilder.Entity<PhoneNumber>().ToTable("PhoneNumber", "PB");
            base.OnModelCreating(modelBuilder);
        }
    }
}
