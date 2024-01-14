using AutoMapper;
using BioMed.Domain.DTOs.DoctorCategory;
using BioMed.Domain.Entities;
using BioMed.Domain.Interfaces.Services;
using BioMed.Domain.Pagination;
using BioMed.Domain.ResourceParameters;
using BioMed.Infrastructure.Persistence;

namespace BioMed.Services.Services
{
    public class DoctorCategoryService : IDoctorCategoryService
    {
        private readonly IMapper _mapper;
        private readonly BioMedDbContext _context;

        public DoctorCategoryService(IMapper mapper,
            BioMedDbContext context)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public PaginatedList<DoctorCategoryDto> GetDoctorCategories(
            DoctorCategoryResourceParameters doctorCategoryResourceParameters)
        {
            var query = _context.DoctorCategories.AsQueryable();

            if (!string.IsNullOrWhiteSpace(doctorCategoryResourceParameters.OrderBy))
            {
                query = doctorCategoryResourceParameters.OrderBy.ToLowerInvariant() switch
                {
                    "doctorId" => query.OrderBy(dc => dc.DoctorId),
                    "doctorIdDesc" => query.OrderByDescending(dc => dc.DoctorId),
                    "categoryId" => query.OrderBy(dc => dc.CategoryId),
                    "categoryIdDesc" => query.OrderByDescending(dc => dc.CategoryId),
                    _ => query.OrderBy(dc => dc.DoctorId),
                };
            }

            var doctorCaregories = query.ToPaginatedList(doctorCategoryResourceParameters.PageSize,
                doctorCategoryResourceParameters.PageNumber);
            var doctorCategoryDtos = _mapper.Map<List<DoctorCategoryDto>>(doctorCaregories);

            return new PaginatedList<DoctorCategoryDto>(doctorCategoryDtos,
                doctorCaregories.TotalPages,
                doctorCaregories.CurrentPage,
                doctorCaregories.PageSize);
        }

        public DoctorCategoryDto? GetDoctorCategoryById(int id)
        {
            var doctorcategory = _context.DoctorCategories.FirstOrDefault(c => c.Id == id);

            return _mapper.Map<DoctorCategoryDto>(doctorcategory);
        }

        public DoctorCategoryDto CreateDoctorCategory(
            DoctorCategoryForCreateDto doctorCategoryToCreate)
        {
            var doctorCategoryEntity = _mapper.Map<DoctorCategory>(doctorCategoryToCreate);

            _context.DoctorCategories.Add(doctorCategoryEntity);
            _context.SaveChanges();

            return _mapper.Map<DoctorCategoryDto>(doctorCategoryEntity);
        }

        public void UpdateDoctorCategory(
            DoctorCategoryForUpdateDto doctorCategoryToUpdate)
        {
            var doctorCategory = _mapper.Map<DoctorCategory>(doctorCategoryToUpdate);

            _context.DoctorCategories.Update(doctorCategory);
            _context.SaveChanges();
        }

        public void DeleteDoctorCategory(int id)
        {
            var doctorCategory = _context.DoctorCategories.FirstOrDefault(dc => dc.Id == id);

            if(doctorCategory is not null)
            {
                _context.DoctorCategories.Remove(doctorCategory);
                _context.SaveChanges();
            }
        }
    }
}
