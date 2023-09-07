using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Mf.EntityFrameworkCore
{
    public static class MfDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<MfDbContext> builder, string connectionString)
        {
            builder.UseNpgsql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<MfDbContext> builder, DbConnection connection)
        {
            builder.UseNpgsql(connection);
        }
    }
}
