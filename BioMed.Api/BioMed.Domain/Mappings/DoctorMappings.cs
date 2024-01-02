using AutoMapper;
using BioMed.Domain.DTOs.Doctor;
using BioMed.Domain.Entities;

namespace BioMed.Domain.Mappings
{
    internal class DoctorMappings : Profile
    {
        public DoctorMappings() 
        {
            CreateMap<Doctor, DoctorDto>();
            CreateMap<DoctorDto, Doctor>();
            CreateMap<DoctorForCreateDto, Doctor>();
            CreateMap<DoctorForUpdateDto, Doctor>();
        }
    }
}
