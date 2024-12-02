using Abp.Application.Services;
using InvoiceManagementSystem.Authorization.Accounts.Dto;
using System.Threading.Tasks;

namespace InvoiceManagementSystem.Authorization.Accounts;

public interface IAccountAppService : IApplicationService
{
    Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

    Task<RegisterOutput> Register(RegisterInput input);
}
