using AutoMapper;
using BioMed.Domain.DTOs.Doctor;
using BioMed.Domain.Entities;
using BioMed.Domain.Interfaces.Services;
using BioMed.Domain.Pagination;
using BioMed.Domain.ResourceParameters;
using BioMed.Infrastructure.Persistence;

namespace BioMed.Services.Services
{
    public class DoctorService : IDoctorService
    {
        private readonly IMapper _mapper;
        private readonly BioMedDbContext _context;

        public DoctorService(IMapper mapper,
            BioMedDbContext context)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public PaginatedList<DoctorDto> GetDoctors(
            DoctorResourceParameters doctorResourceParameters)
        {
            var query = _context.Doctors.AsQueryable();

            if(!string.IsNullOrWhiteSpace(doctorResourceParameters.SearchString))
            {
                query = query.Where(d => d.FullName.Contains(doctorResourceParameters.SearchString));
            }
            if (!string.IsNullOrWhiteSpace(doctorResourceParameters.OrderBy))
            {
                query = doctorResourceParameters.OrderBy.ToLowerInvariant() switch
                {
                    "fullNmae" => query.OrderBy(d => d.FullName),
                    "fullNameDesc" => query.OrderByDescending(d => d.FullName),
                    "phoneNumber" => query.OrderBy(d => d.PhoneNumber),
                    "phoneNumberDesc" => query.OrderByDescending(d => d.PhoneNumber),
                    "email" => query.OrderBy(d => d.Email),
                    "emailDesc" => query.OrderByDescending(d => d.Email),
                    "pricePerVisit" => query.OrderBy(d => d.PricePerVisit),
                    "pricePerVisitDesc" => query.OrderByDescending(d => d.PricePerVisit),
                    _ => query.OrderBy(d => d.FullName),
                };
            }

            var doctors = query.ToPaginatedList(doctorResourceParameters.PageSize,
                doctorResourceParameters.PageNumber);
            var doctorDtos = _mapper.Map<List<DoctorDto>>(doctors);

            return new PaginatedList<DoctorDto>(doctorDtos,
                doctors.PageSize,
                doctors.TotalPages,
                doctors.CurrentPage);
        }

        public DoctorDto? GetDoctorById(int id)
        {
            var doctor = _context.Doctors.FirstOrDefault(d => d.Id == id);

            return _mapper.Map<DoctorDto>(doctor);
        }

        public DoctorDto CreateDoctor(DoctorForCreateDto doctorToCreate)
        {
            var doctorEntity = _mapper.Map<Doctor>(doctorToCreate);

            _context.Doctors.Add(doctorEntity);
            _context.SaveChanges();

            return _mapper.Map<DoctorDto>(doctorEntity);
        }

        public void UpdateDoctor(DoctorForUpdateDto doctorToUpdate)
        {
            var doctor = _mapper.Map<Doctor>(doctorToUpdate);

            _context.Doctors.Update(doctor);
            _context.SaveChanges();
        }

        public void DeleteDoctor(int id)
        {
            var doctor = _context.Doctors.FirstOrDefault(d => d.Id == id);

            if(doctor is not null)
            {
                _context.Doctors.Remove(doctor); 
                _context.SaveChanges();
            }
        }
    }
}
