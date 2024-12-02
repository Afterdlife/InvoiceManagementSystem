using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using InvoiceManagementSystem.Configuration;
using InvoiceManagementSystem.EntityFrameworkCore;
using InvoiceManagementSystem.Migrator.DependencyInjection;
using Castle.MicroKernel.Registration;
using Microsoft.Extensions.Configuration;

namespace InvoiceManagementSystem.Migrator;

[DependsOn(typeof(InvoiceManagementSystemEntityFrameworkModule))]
public class InvoiceManagementSystemMigratorModule : AbpModule
{
    private readonly IConfigurationRoot _appConfiguration;

    public InvoiceManagementSystemMigratorModule(InvoiceManagementSystemEntityFrameworkModule abpProjectNameEntityFrameworkModule)
    {
        abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

        _appConfiguration = AppConfigurations.Get(
            typeof(InvoiceManagementSystemMigratorModule).GetAssembly().GetDirectoryPathOrNull()
        );
    }

    public override void PreInitialize()
    {
        Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
            InvoiceManagementSystemConsts.ConnectionStringName
        );

        Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        Configuration.ReplaceService(
            typeof(IEventBus),
            () => IocManager.IocContainer.Register(
                Component.For<IEventBus>().Instance(NullEventBus.Instance)
            )
        );
    }

    public override void Initialize()
    {
        IocManager.RegisterAssemblyByConvention(typeof(InvoiceManagementSystemMigratorModule).GetAssembly());
        ServiceCollectionRegistrar.Register(IocManager);
    }
}
