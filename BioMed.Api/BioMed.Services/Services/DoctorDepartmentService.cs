using AutoMapper;
using BioMed.Domain.DTOs.DoctorDepartment;
using BioMed.Domain.Entities;
using BioMed.Domain.Interfaces.Services;
using BioMed.Domain.Pagination;
using BioMed.Domain.ResourceParameters;
using BioMed.Infrastructure.Persistence;

namespace BioMed.Services.Services
{
    public class DoctorDepartmentService : IDoctorDepartmentService
    {
        private readonly IMapper _mapper;
        private readonly BioMedDbContext _context;

        public DoctorDepartmentService(IMapper mapper,
            BioMedDbContext context)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public PaginatedList<DoctorDepartmentDto> GetDoctorDepartments(
            DoctorDepartmentResourceParameters doctorDepartmentResourceParameters)
        {
            var query = _context.DoctorDepartments.AsQueryable();

            if (!string.IsNullOrWhiteSpace(doctorDepartmentResourceParameters.OrderBy))
            {
                query = doctorDepartmentResourceParameters.OrderBy.ToLowerInvariant() switch
                {
                    "doctorId" => query.OrderBy(dc => dc.DoctorId),
                    "doctorIdDesc" => query.OrderByDescending(dc => dc.DoctorId),
                    "departmentId" => query.OrderBy(dc => dc.DepartmentId),
                    "departmentIdDesc" => query.OrderByDescending(dc => dc.DepartmentId),
                    _ => query.OrderBy(dc => dc.DoctorId),
                };
            }

            var doctorDepartments = query.ToPaginatedList(doctorDepartmentResourceParameters.PageSize,
                doctorDepartmentResourceParameters.PageNumber);
            var doctorDepartmentDtos = _mapper.Map<List<DoctorDepartmentDto>>(doctorDepartments);

            return new PaginatedList<DoctorDepartmentDto>(doctorDepartmentDtos,
                doctorDepartments.TotalPages,
                doctorDepartments.CurrentPage,
                doctorDepartments.PageSize);
        }

        public DoctorDepartmentDto? GetDoctorDepartmentById(int id)
        {
            var doctorDepartment = _context.DoctorDepartments.FirstOrDefault(c => c.Id == id);

            return _mapper.Map<DoctorDepartmentDto>(doctorDepartment);
        }

        public DoctorDepartmentDto CreateDoctorDepartment(
            DoctorDepartmentForCreateDto doctorDepartmentToCreate)
        {
            var doctorDepartmentEntity = _mapper.Map<DoctorDepartment>(doctorDepartmentToCreate);

            _context.DoctorDepartments.Add(doctorDepartmentEntity);
            _context.SaveChanges();

            return _mapper.Map<DoctorDepartmentDto>(doctorDepartmentEntity);
        }

        public void UpdateDoctorDepartment(
            DoctorDepartmentForUpdateDto doctorDepartmentToUpdate)
        {
            var doctorDepartment = _mapper.Map<DoctorDepartment>(doctorDepartmentToUpdate);

            _context.DoctorDepartments.Update(doctorDepartment);
            _context.SaveChanges();
        }

        public void DeleteDoctorDepartment(int id)
        {
            var doctorDepartment = _context.DoctorDepartments
                .FirstOrDefault(d => d.Id == id);

            if(doctorDepartment is not null)
            {
                _context.DoctorDepartments .Remove(doctorDepartment);
                _context.SaveChanges();
            }

        }
    }
}
