using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using InvoiceManagementSystem.Authorization;

namespace InvoiceManagementSystem;

[DependsOn(
    typeof(InvoiceManagementSystemCoreModule),
    typeof(AbpAutoMapperModule))]
public class InvoiceManagementSystemApplicationModule : AbpModule
{
    public override void PreInitialize()
    {
        Configuration.Authorization.Providers.Add<InvoiceManagementSystemAuthorizationProvider>();
    }

    public override void Initialize()
    {
        var thisAssembly = typeof(InvoiceManagementSystemApplicationModule).GetAssembly();

        IocManager.RegisterAssemblyByConvention(thisAssembly);

        Configuration.Modules.AbpAutoMapper().Configurators.Add(
            // Scan the assembly for classes which inherit from AutoMapper.Profile
            cfg => cfg.AddMaps(thisAssembly)
        );
    }
}
