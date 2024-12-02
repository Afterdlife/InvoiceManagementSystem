using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagementSystem.Models
{
    public class ReceivableDetail : FullAuditedEntity<int>
    {
        public int CustomerID { get; set; }
        public int InvoiceID { get; set; }
        public decimal AmountDue { get; set; }
        public DateTime DueDate { get; set; }
    }
}
