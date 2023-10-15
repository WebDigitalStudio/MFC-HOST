using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Mf.Authorization.Roles;
using Mf.Authorization.Users;
using Mf.MultiTenancy;

namespace Mf.EntityFrameworkCore
{
    public class MfDbContext : AbpZeroDbContext<Tenant, Role, User, MfDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public MfDbContext(DbContextOptions<MfDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
