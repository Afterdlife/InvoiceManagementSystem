using Abp.MultiTenancy;
using InvoiceManagementSystem.Authorization.Users;

namespace InvoiceManagementSystem.MultiTenancy;

public class Tenant : AbpTenant<User>
{
    public Tenant()
    {
    }

    public Tenant(string tenancyName, string name)
        : base(tenancyName, name)
    {
    }
}
