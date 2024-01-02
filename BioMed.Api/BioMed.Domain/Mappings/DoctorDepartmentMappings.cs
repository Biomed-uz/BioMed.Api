using AutoMapper;
using BioMed.Domain.DTOs.DoctorDepartment;
using BioMed.Domain.Entities;

namespace BioMed.Domain.Mappings
{
    internal class DoctorDepartmentMappings : Profile
    {
        public DoctorDepartmentMappings() 
        {
            CreateMap<DoctorDepartment, DoctorDepartmentDto>();
            CreateMap<DoctorDepartmentDto, DoctorDepartment>();
            CreateMap<DoctorDepartmentForCreateDto, DoctorDepartment>();
            CreateMap<DoctorDepartmentForUpdateDto, DoctorDepartment>();
        }
    }
}
