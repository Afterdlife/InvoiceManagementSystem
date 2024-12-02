using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using InvoiceManagementSystem.Models;
using InvoiceManagementSystem.PaymentReceives.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagementSystem.PaymentReceives
{
    public class PaymentReceiveAppservice : AsyncCrudAppService<PaymentReceived, PaymentReceivedDto, int, PagedAndSortedResultRequestDto, CreateUpdatePaymentReceivedDto>
    {
        public PaymentReceiveAppservice(IRepository<PaymentReceived, int> repository)
            : base(repository)
        {
        }
    }
}
