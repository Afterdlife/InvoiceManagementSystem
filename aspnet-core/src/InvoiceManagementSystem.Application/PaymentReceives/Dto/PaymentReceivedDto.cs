using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagementSystem.PaymentReceives.Dto
{
    public class PaymentReceivedDto : FullAuditedEntityDto<int>
    {
        public int InvoiceID { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal Amount { get; set; }
    }
}
