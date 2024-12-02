using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using AutoMapper;
using InvoiceManagementSystem.Estimations.Dto;
using InvoiceManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagementSystem.Estimations
{
    public class EstimationAppService : AsyncCrudAppService<Estimation, EstimationDto, int, PagedAndSortedResultRequestDto, CreateUpdateEstimationDto>
    {
        public EstimationAppService(IRepository<Estimation, int> repository)
            : base(repository)
        {
        }
    }

    public class EstimationMappingProfile : Profile
    {
        public EstimationMappingProfile()
        {
            CreateMap<Estimation, EstimationDto>();
            CreateMap<CreateUpdateEstimationDto, Estimation>();
            CreateMap<Estimation, CreateUpdateEstimationDto>();
        }
    }
}
