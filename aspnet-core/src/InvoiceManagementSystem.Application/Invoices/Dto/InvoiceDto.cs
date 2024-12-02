using Abp.Application.Services.Dto;
using InvoiceManagementSystem.EnumModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagementSystem.Invoices.Dto
{
    public class InvoiceDto : FullAuditedEntityDto<int>
    {
        public int CustomerID { get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime DueDate { get; set; }
        public decimal TotalAmount { get; set; }
        public InvoiceStatus Status { get; set; }
    }
}
