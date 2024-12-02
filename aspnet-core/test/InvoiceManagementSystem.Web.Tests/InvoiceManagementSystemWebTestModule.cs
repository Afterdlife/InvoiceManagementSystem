using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using InvoiceManagementSystem.EntityFrameworkCore;
using InvoiceManagementSystem.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace InvoiceManagementSystem.Web.Tests;

[DependsOn(
    typeof(InvoiceManagementSystemWebMvcModule),
    typeof(AbpAspNetCoreTestBaseModule)
)]
public class InvoiceManagementSystemWebTestModule : AbpModule
{
    public InvoiceManagementSystemWebTestModule(InvoiceManagementSystemEntityFrameworkModule abpProjectNameEntityFrameworkModule)
    {
        abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
    }

    public override void PreInitialize()
    {
        Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
    }

    public override void Initialize()
    {
        IocManager.RegisterAssemblyByConvention(typeof(InvoiceManagementSystemWebTestModule).GetAssembly());
    }

    public override void PostInitialize()
    {
        IocManager.Resolve<ApplicationPartManager>()
            .AddApplicationPartsIfNotAddedBefore(typeof(InvoiceManagementSystemWebMvcModule).Assembly);
    }
}