using AutoMapper;
using BioMed.Domain.DTOs.Disease;
using BioMed.Domain.Entities;

namespace BioMed.Domain.Mappings
{
    internal class DiseaseMappings : Profile
    {
        public DiseaseMappings() 
        {
            CreateMap<Disease, DiseaseDto>();
            CreateMap<DiseaseDto, Disease>();
            CreateMap<DiseaseForCreateDto, Disease>();
            CreateMap<DiseaseForUpdateDto, Disease>();
        }
    }
}
