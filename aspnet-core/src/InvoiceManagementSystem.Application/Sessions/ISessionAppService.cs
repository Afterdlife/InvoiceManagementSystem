using Abp.Application.Services;
using InvoiceManagementSystem.Sessions.Dto;
using System.Threading.Tasks;

namespace InvoiceManagementSystem.Sessions;

public interface ISessionAppService : IApplicationService
{
    Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
}
