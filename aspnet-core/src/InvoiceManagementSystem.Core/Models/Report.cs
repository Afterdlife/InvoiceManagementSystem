using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagementSystem.Models
{
    public class Report : FullAuditedEntity<int>
    {
        public string ReportType { get; set; }
        public DateTime GeneratedDate { get; set; }
        public string Content { get; set; }
    }
}
