using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace InvoiceManagementSystem.Controllers
{
    public abstract class InvoiceManagementSystemControllerBase : AbpController
    {
        protected InvoiceManagementSystemControllerBase()
        {
            LocalizationSourceName = InvoiceManagementSystemConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
