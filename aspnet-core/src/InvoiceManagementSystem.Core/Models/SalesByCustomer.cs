using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagementSystem.Models
{
    public class SalesByCustomer : FullAuditedEntity<int>
    {
        public int CustomerID { get; set; }
        public DateTime SalesDate { get; set; }
        public decimal TotalSales { get; set; }
    }
}
