using Abp.EntityFrameworkCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Zero.EntityFrameworkCore;
using InvoiceManagementSystem.EntityFrameworkCore.Seed;

namespace InvoiceManagementSystem.EntityFrameworkCore;

[DependsOn(
    typeof(InvoiceManagementSystemCoreModule),
    typeof(AbpZeroCoreEntityFrameworkCoreModule))]
public class InvoiceManagementSystemEntityFrameworkModule : AbpModule
{
    /* Used it tests to skip dbcontext registration, in order to use in-memory database of EF Core */
    public bool SkipDbContextRegistration { get; set; }

    public bool SkipDbSeed { get; set; }

    public override void PreInitialize()
    {
        if (!SkipDbContextRegistration)
        {
            Configuration.Modules.AbpEfCore().AddDbContext<InvoiceManagementSystemDbContext>(options =>
            {
                if (options.ExistingConnection != null)
                {
                    InvoiceManagementSystemDbContextConfigurer.Configure(options.DbContextOptions, options.ExistingConnection);
                }
                else
                {
                    InvoiceManagementSystemDbContextConfigurer.Configure(options.DbContextOptions, options.ConnectionString);
                }
            });
        }
    }

    public override void Initialize()
    {
        IocManager.RegisterAssemblyByConvention(typeof(InvoiceManagementSystemEntityFrameworkModule).GetAssembly());
    }

    public override void PostInitialize()
    {
        if (!SkipDbSeed)
        {
            SeedHelper.SeedHostDb(IocManager);
        }
    }
}
