using Abp.Application.Services.Dto;
using Abp.Application.Services;
using Abp.Domain.Repositories;
using InvoiceManagementSystem.Estimations.Dto;
using InvoiceManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvoiceManagementSystem.InvoiceDetails.Dto;

namespace InvoiceManagementSystem.InvoiceDetails
{
    public class InvoiceDetailAppService : AsyncCrudAppService<InvoiceDetail, InvoiceDetailDto, int, PagedAndSortedResultRequestDto, CreateUpdateInvoiceDetailDto>
    {
        public InvoiceDetailAppService(IRepository<InvoiceDetail, int> repository)
            : base(repository)
        {
        }
    }
}
