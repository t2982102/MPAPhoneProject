using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace MPAPhoneProject.EntityFrameworkCore
{
    public static class MPAPhoneProjectDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<MPAPhoneProjectDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<MPAPhoneProjectDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
