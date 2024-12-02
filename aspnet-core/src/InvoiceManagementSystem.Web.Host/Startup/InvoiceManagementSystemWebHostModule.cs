using Abp.Modules;
using Abp.Reflection.Extensions;
using InvoiceManagementSystem.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace InvoiceManagementSystem.Web.Host.Startup
{
    [DependsOn(
       typeof(InvoiceManagementSystemWebCoreModule))]
    public class InvoiceManagementSystemWebHostModule : AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public InvoiceManagementSystemWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(InvoiceManagementSystemWebHostModule).GetAssembly());
        }
    }
}
