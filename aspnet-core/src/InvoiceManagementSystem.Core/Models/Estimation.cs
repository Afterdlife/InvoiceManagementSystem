using Abp.Domain.Entities.Auditing;
using InvoiceManagementSystem.EnumModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagementSystem.Models
{
    public class Estimation : FullAuditedEntity<int>
    {
        public int CustomerID { get; set; }
        public DateTime EstimationDate { get; set; }
        public decimal TotalAmount { get; set; }
        public EstimationStatus Status { get; set; }
    }
}
