using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagementSystem.ReceivableDetails.Dto
{
    public class CreateUpdateReceivableDetailDto : EntityDto<int>
    {
        public int CustomerID { get; set; }
        public int InvoiceID { get; set; }
        public decimal AmountDue { get; set; }
        public DateTime DueDate { get; set; }
    }
}
