using AutoMapper;
using BioMed.Domain.DTOs.Visit;
using BioMed.Domain.Entities;

namespace BioMed.Domain.Mappings
{
    internal class VisitMappings : Profile
    {
        public VisitMappings() 
        {
            CreateMap<Visit, VisitDto>();
            CreateMap<VisitDto, Visit>();
            CreateMap<VisitForCreateDto, Visit>();
            CreateMap<VisitForUpdateDto, Visit>();
        }
    }
}
