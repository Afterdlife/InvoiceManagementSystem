using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using InvoiceManagementSystem.Invoices.Dto;
using InvoiceManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagementSystem.Invoices
{
    public class InvoiceAppService : AsyncCrudAppService<Invoice, InvoiceDto, int, PagedAndSortedResultRequestDto, CreateUpdateInvoiceDto>
    {
        public InvoiceAppService(IRepository<Invoice, int> repository)
            : base(repository)
        {
        }
    }
}
