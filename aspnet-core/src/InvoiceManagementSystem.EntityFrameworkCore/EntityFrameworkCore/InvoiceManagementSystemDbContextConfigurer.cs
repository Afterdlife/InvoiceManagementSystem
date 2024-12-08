using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace InvoiceManagementSystem.EntityFrameworkCore;

public static class InvoiceManagementSystemDbContextConfigurer
{
    public static void Configure(DbContextOptionsBuilder<InvoiceManagementSystemDbContext> builder, string connectionString)
    {
        //builder.UseSqlServer(connectionString);
        builder.UseNpgsql(connectionString);
    }

    public static void Configure(DbContextOptionsBuilder<InvoiceManagementSystemDbContext> builder, DbConnection connection)
    {
        //builder.UseSqlServer(connection);
        builder.UseNpgsql(connection);
    }
}
