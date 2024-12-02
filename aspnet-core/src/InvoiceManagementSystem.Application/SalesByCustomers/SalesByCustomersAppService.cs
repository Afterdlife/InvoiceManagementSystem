using Abp.Application.Services.Dto;
using Abp.Application.Services;
using Abp.Domain.Repositories;
using InvoiceManagementSystem.Models;
using InvoiceManagementSystem.Reports.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvoiceManagementSystem.SalesByCustomers.Dto;

namespace InvoiceManagementSystem.SalesByCustomers
{
    public class SalesByCustomersAppService : AsyncCrudAppService<SalesByCustomer, SalesByCustomerDto, int, PagedAndSortedResultRequestDto, CreateUpdateSalesByCustomerDto>
    {
        public SalesByCustomersAppService(IRepository<SalesByCustomer, int> repository)
            : base(repository)
        {
        }
    }
}