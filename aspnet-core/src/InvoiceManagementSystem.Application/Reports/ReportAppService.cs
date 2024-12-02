using Abp.Application.Services.Dto;
using Abp.Application.Services;
using Abp.Domain.Repositories;
using InvoiceManagementSystem.Models;
using InvoiceManagementSystem.ReceivableDetails.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvoiceManagementSystem.Reports.Dto;

namespace InvoiceManagementSystem.Reports
{
    public class ReportAppService : AsyncCrudAppService<Report, ReportDto, int, PagedAndSortedResultRequestDto, CreateUpdateReportDto>
    {
        public ReportAppService(IRepository<Report, int> repository)
            : base(repository)
        {
        }
    }
}