using Abp.Authorization;
using InvoiceManagementSystem.Authorization.Roles;
using InvoiceManagementSystem.Authorization.Users;

namespace InvoiceManagementSystem.Authorization;

public class PermissionChecker : PermissionChecker<Role, User>
{
    public PermissionChecker(UserManager userManager)
        : base(userManager)
    {
    }
}
