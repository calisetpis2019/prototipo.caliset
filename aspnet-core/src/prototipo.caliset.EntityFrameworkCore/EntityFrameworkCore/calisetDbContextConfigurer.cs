using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace prototipo.caliset.EntityFrameworkCore
{
    public static class calisetDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<calisetDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<calisetDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
