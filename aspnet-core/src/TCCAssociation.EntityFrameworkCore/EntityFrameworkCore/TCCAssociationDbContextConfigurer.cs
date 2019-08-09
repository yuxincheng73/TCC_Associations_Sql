using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace TCCAssociation.EntityFrameworkCore
{
    public static class TCCAssociationDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<TCCAssociationDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<TCCAssociationDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
