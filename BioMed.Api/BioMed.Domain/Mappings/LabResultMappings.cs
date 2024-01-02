using AutoMapper;
using BioMed.Domain.DTOs.LabResult;
using BioMed.Domain.Entities;

namespace BioMed.Domain.Mappings
{
    internal class LabResultMappings : Profile
    {
        public LabResultMappings() 
        {
            CreateMap<LabResult, LabResultDto>();
            CreateMap<LabResultDto, LabResult>();
            CreateMap<LabResultForCreateDto, LabResult>();
            CreateMap<LabResultForUpdateDto, LabResult>();
        }
    }
}
