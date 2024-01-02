using AutoMapper;
using BioMed.Domain.DTOs.DiseaseCategory;
using BioMed.Domain.Entities;

namespace BioMed.Domain.Mappings
{
    internal class DiseaseCategoryMappings : Profile
    {
        public DiseaseCategoryMappings() 
        {
            CreateMap<DiseaseCategory, DiseaseCategoryDto>();
            CreateMap<DiseaseCategoryDto, DiseaseCategory>();
            CreateMap<DiseaseCategoryForCreateDto, DiseaseCategory>();
            CreateMap<DiseaseCategoryForUpdateDto, DiseaseCategory>();
        }
    }
}
