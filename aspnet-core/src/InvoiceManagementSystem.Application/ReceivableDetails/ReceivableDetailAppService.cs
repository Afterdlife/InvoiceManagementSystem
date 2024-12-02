using Abp.Application.Services.Dto;
using Abp.Application.Services;
using Abp.Domain.Repositories;
using InvoiceManagementSystem.Models;
using InvoiceManagementSystem.PaymentReceives.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvoiceManagementSystem.ReceivableDetails.Dto;

namespace InvoiceManagementSystem.ReceivableDetails
{
    public class ReceivableDetailAppService : AsyncCrudAppService<ReceivableDetail, ReceivableDetailDto, int, PagedAndSortedResultRequestDto, CreateUpdateReceivableDetailDto>
    {
        public ReceivableDetailAppService(IRepository<ReceivableDetail, int> repository)
            : base(repository)
        {
        }
    }
}
