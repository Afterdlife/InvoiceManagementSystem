using Abp.Application.Services;
using InvoiceManagementSystem.MultiTenancy.Dto;

namespace InvoiceManagementSystem.MultiTenancy;

public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
{
}

