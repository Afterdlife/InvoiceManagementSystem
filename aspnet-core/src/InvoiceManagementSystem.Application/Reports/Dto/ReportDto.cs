using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagementSystem.Reports.Dto
{
    public class ReportDto : FullAuditedEntityDto<int>
    {
        public string ReportType { get; set; }
        public DateTime GeneratedDate { get; set; }
        public string Content { get; set; }
    }
}
