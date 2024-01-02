using AutoMapper;
using BioMed.Domain.DTOs.TestType;
using BioMed.Domain.Entities;

namespace BioMed.Domain.Mappings
{
    internal class TestTypeMappings : Profile
    {
        public TestTypeMappings() 
        {
            CreateMap<TestType, TestTypeDto>();
            CreateMap<TestTypeDto, TestType>();
            CreateMap<TestTypeForCreateDto, TestType>();
            CreateMap<TestTypeForUpdateDto, TestType>();
        }
    }
}
