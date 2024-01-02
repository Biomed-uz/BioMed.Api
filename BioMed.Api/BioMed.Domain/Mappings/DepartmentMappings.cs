using AutoMapper;
using BioMed.Domain.DTOs.Department;
using BioMed.Domain.Entities;

namespace BioMed.Domain.Mappings
{
    internal class DepartmentMappings : Profile
    {
        public DepartmentMappings() 
        {
            CreateMap<Department, DepartmentDto>();
            CreateMap<DepartmentDto, Department>();
            CreateMap<DepartmentForCreateDto, Department>();
            CreateMap<DepartmentForUpdateDto, Department>();
        }
    }
}
