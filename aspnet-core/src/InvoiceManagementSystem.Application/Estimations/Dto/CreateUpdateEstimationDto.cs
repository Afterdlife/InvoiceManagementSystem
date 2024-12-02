using Abp.Application.Services.Dto;
using InvoiceManagementSystem.EnumModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagementSystem.Estimations.Dto
{
    public class CreateUpdateEstimationDto : EntityDto<int>
    {
        public int CustomerID { get; set; }
        public DateTime EstimationDate { get; set; }
        public decimal TotalAmount { get; set; }
        public EstimationStatus Status { get; set; }
    }
}
