using Abp.Zero.EntityFrameworkCore;
using InvoiceManagementSystem.Authorization.Roles;
using InvoiceManagementSystem.Authorization.Users;
using InvoiceManagementSystem.Models;
using InvoiceManagementSystem.MultiTenancy;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System;
using Volo.Abp.Data;

namespace InvoiceManagementSystem.EntityFrameworkCore;

[ConnectionStringName("Default")]
public class InvoiceManagementSystemDbContext : AbpZeroDbContext<Tenant, Role, User, InvoiceManagementSystemDbContext>
{
    /* Define a DbSet for each entity of the application */

    public DbSet<Customer> Customers { get; set; }
    public DbSet<Invoice> Invoices { get; set; }
    public DbSet<InvoiceDetail> InvoiceDetails { get; set; }
    public DbSet<PaymentReceived> PaymentsReceived { get; set; }
    public DbSet<Estimation> Estimations { get; set; }
    public DbSet<Report> Reports { get; set; }
    public DbSet<SalesByCustomer> SalesByCustomers { get; set; }
    public DbSet<ReceivableDetail> ReceivableDetails { get; set; }

    public InvoiceManagementSystemDbContext(DbContextOptions<InvoiceManagementSystemDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Customer relationships
        modelBuilder.Entity<Customer>()
            .HasMany<Invoice>()
            .WithOne()
            .HasForeignKey(i => i.CustomerID);

        modelBuilder.Entity<Customer>()
            .HasMany<Estimation>()
            .WithOne()
            .HasForeignKey(e => e.CustomerID);

        // Invoice relationships
        modelBuilder.Entity<Invoice>()
            .HasMany<InvoiceDetail>()
            .WithOne()
            .HasForeignKey(id => id.InvoiceID);

        modelBuilder.Entity<Invoice>()
            .HasMany<PaymentReceived>()
            .WithOne()
            .HasForeignKey(pr => pr.InvoiceID);

    }
    protected override void ConfigureConventions(ModelConfigurationBuilder builder)
    {
        base.ConfigureConventions(builder);
        builder.Properties<DateOnly>()
            .HaveConversion<DateOnlyConverter, DateOnlyComparer>()
        .HaveColumnType("date");
    }
}
