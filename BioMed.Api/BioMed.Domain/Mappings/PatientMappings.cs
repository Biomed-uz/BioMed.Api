using AutoMapper;
using BioMed.Domain.DTOs.Patient;
using BioMed.Domain.Entities;

namespace BioMed.Domain.Mappings
{
    internal class PatientMappings : Profile
    {
        public PatientMappings() 
        {
            CreateMap<Patient, PatientDto>();
            CreateMap<PatientDto, Patient>();
            CreateMap<PatientForCreateDto, Patient>();
            CreateMap<PatientForUpdateDto, Patient>();
        }
    }
}
