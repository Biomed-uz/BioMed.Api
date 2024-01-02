using AutoMapper;
using BioMed.Domain.DTOs.Treatment;
using BioMed.Domain.Entities;

namespace BioMed.Domain.Mappings
{
    internal class TreatmentMappings : Profile
    {
        public TreatmentMappings() 
        {
            CreateMap<Treatment, TreatmentDto>();
            CreateMap<TreatmentDto, Treatment>();
            CreateMap<TreatmentForCreateDto, Treatment>();
            CreateMap<TreatmentForUpdateDto, Treatment>();
        }
    }
}
