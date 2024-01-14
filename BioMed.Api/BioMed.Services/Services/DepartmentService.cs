using AutoMapper;
using BioMed.Domain.DTOs.Department;
using BioMed.Domain.Entities;
using BioMed.Domain.Interfaces.Services;
using BioMed.Domain.Pagination;
using BioMed.Domain.ResourceParameters;
using BioMed.Infrastructure.Persistence;

namespace BioMed.Services.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IMapper _mapper;
        private readonly BioMedDbContext _context;

        public DepartmentService(IMapper mapper, 
            BioMedDbContext dbContext)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _context = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public PaginatedList<DepartmentDto> GetDepartments(
            DepartmentResourceParameters departmentResourceParameters)
        {
            var query = _context.Departments.AsQueryable();

            if (!string.IsNullOrWhiteSpace(departmentResourceParameters.SearchString))
            {
                query = query.Where(x => x.Name.Contains(departmentResourceParameters.SearchString));
            }

            if (!string.IsNullOrEmpty(departmentResourceParameters.OrderBy))
            {
                query = departmentResourceParameters.OrderBy.ToLowerInvariant() switch
                {
                    "name" => query.OrderBy(x => x.Name),
                    "namedesc" => query.OrderByDescending(x => x.Name),
                    _ => query.OrderBy(x => x.Name),
                };
            }
            var departments = query.ToPaginatedList(departmentResourceParameters.PageSize,
                departmentResourceParameters.PageNumber);

            var departmentDtos = _mapper.Map<List<DepartmentDto>>(departments);

            return new PaginatedList<DepartmentDto>(departmentDtos,
                departments.TotalCount,
                departments.CurrentPage,
                departments.PageSize);
        }

        public DepartmentDto? GetDepartmentById(int id)
        {
            var department = _context.Departments.FirstOrDefault(x => x.Id == id);

            return _mapper.Map<DepartmentDto>(department);
        }

        public DepartmentDto CreateDepartment(DepartmentForCreateDto departmentToCreate)
        {
            var departmentEntity = _mapper.Map<Department>(departmentToCreate);

            _context.Departments.Add(departmentEntity);
            _context.SaveChanges();

            return _mapper.Map<DepartmentDto>(departmentEntity);
        }

        public void UpdateDepartment(DepartmentForUpdateDto departmentToUpdate)
        {
            var departmentEntity = _mapper.Map<Department>(departmentToUpdate);

            _context.Departments.Update(departmentEntity);
            _context.SaveChanges();
        }

        public void DeleteDepartment(int id)
        {
            var department = _context.Departments.FirstOrDefault(d => d.Id == id);

            if(department is not null)
            {
                _context.Departments.Remove(department);
                _context.SaveChanges();
            }
        }    
    }
}
