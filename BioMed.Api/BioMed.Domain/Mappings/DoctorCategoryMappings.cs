using AutoMapper;
using BioMed.Domain.DTOs.DoctorCategory;
using BioMed.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioMed.Domain.Mappings
{
    internal class DoctorCategoryMappings : Profile
    {
        public DoctorCategoryMappings() 
        {
            CreateMap<DoctorCategory, DoctorCategoryDto>();
            CreateMap<DoctorCategoryDto, DoctorCategory>();
            CreateMap<DoctorCategoryForCreateDto, DoctorCategory>();
            CreateMap<DoctorCategoryForUpdateDto, DoctorCategory>();
        }
    }
}
