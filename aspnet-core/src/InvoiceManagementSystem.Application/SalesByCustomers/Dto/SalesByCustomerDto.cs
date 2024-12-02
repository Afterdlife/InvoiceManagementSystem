using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagementSystem.SalesByCustomers.Dto
{
    public class SalesByCustomerDto : FullAuditedEntityDto<int>
    {
        public int CustomerID { get; set; }
        public DateTime SalesDate { get; set; }
        public decimal TotalSales { get; set; }
    }
}
