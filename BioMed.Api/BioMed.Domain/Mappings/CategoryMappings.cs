using AutoMapper;
using BioMed.Domain.DTOs.Category;
using BioMed.Domain.Entities;

namespace BioMed.Domain.Mappings
{
    internal class CategoryMappings : Profile
    {
        public CategoryMappings() 
        {
            CreateMap<Category, CategoryDto>();
            CreateMap<CategoryDto, Category>();
            CreateMap<CategoryForCreateDto, Category>();
            CreateMap<CategoryForUpdateDto, Category>();
        }
    }
}
