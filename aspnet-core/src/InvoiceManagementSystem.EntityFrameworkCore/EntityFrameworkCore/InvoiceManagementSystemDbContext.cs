using Abp.Zero.EntityFrameworkCore;
using InvoiceManagementSystem.Authorization.Roles;
using InvoiceManagementSystem.Authorization.Users;
using InvoiceManagementSystem.MultiTenancy;
using Microsoft.EntityFrameworkCore;

namespace InvoiceManagementSystem.EntityFrameworkCore;

public class InvoiceManagementSystemDbContext : AbpZeroDbContext<Tenant, Role, User, InvoiceManagementSystemDbContext>
{
    /* Define a DbSet for each entity of the application */

    public InvoiceManagementSystemDbContext(DbContextOptions<InvoiceManagementSystemDbContext> options)
        : base(options)
    {
    }
}
