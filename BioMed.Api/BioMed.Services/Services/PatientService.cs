using AutoMapper;
using BioMed.Domain.DTOs.Patient;
using BioMed.Domain.Entities;
using BioMed.Domain.Interfaces.Services;
using BioMed.Domain.Pagination;
using BioMed.Domain.ResourceParameters;
using BioMed.Infrastructure.Persistence;

namespace BioMed.Services.Services
{
    public class PatientService : IPatientService
    {
        private readonly IMapper _mapper;
        private readonly BioMedDbContext _context;

        public PatientService(IMapper mapper,
            BioMedDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public PaginatedList<PatientDto> GetPatients(PatientResourceParameters patientResourceParameters)
        {
            var query = _context.Patients.AsQueryable();

            if(!string.IsNullOrWhiteSpace(patientResourceParameters.SearchString))
            {
                query = query.Where(p => p.FirstName.Contains(patientResourceParameters.SearchString) 
                || p.LastName.Contains(patientResourceParameters.SearchString) 
                || p.MiddleName.Contains(patientResourceParameters.SearchString));
            }
            if (!string.IsNullOrWhiteSpace(patientResourceParameters.OrderBy))
            {
                query = patientResourceParameters.OrderBy.ToLowerInvariant() switch
                {
                    "firstName" => query.OrderBy(p => p.FirstName),
                    "firstNameDesc" => query.OrderByDescending(p => p.FirstName),
                    "lastName" => query.OrderBy(p => p.LastName),
                    "lastNameDesc" => query.OrderByDescending(p => p.LastName),
                    "middleName" => query.OrderBy(p => p.MiddleName),
                    "middleNameDesc" => query.OrderByDescending(p => p.MiddleName),
                    "phoneNumber" => query.OrderBy(p => p.PhoneNumber),
                    "phoneNumberDesc" => query.OrderByDescending(p => p.PhoneNumber),
                    "email" => query.OrderBy(p => p.Email),
                    "emaildesc" => query.OrderByDescending(p => p.Email),
                    _ => query.OrderBy(p => p.FirstName)
                };
            }

            var patients = query.ToPaginatedList(patientResourceParameters.PageSize,
                patientResourceParameters.PageNumber);
            var patientDtos = _mapper.Map<List<PatientDto>>(patients);

            return new PaginatedList<PatientDto>(patientDtos,
                patients.TotalPages,
                patients.CurrentPage,
                patients.PageSize);
        }

        public PatientDto? GetPatientById(int id)
        {
            var patient = _context.Patients.FirstOrDefault(p => p.Id == id);

            return _mapper.Map<PatientDto>(patient);
        }

        public PatientDto CreatePatient(PatientForCreateDto patientToCreate)
        {
            var patientEntity = _mapper.Map<Patient>(patientToCreate);

            _context.Patients.Add(patientEntity);
            _context.SaveChanges();

            return _mapper.Map<PatientDto>(patientEntity);
        }

        public void UpdatePatient(PatientForUpdateDto patientToUpdate)
        {
            var patient = _mapper.Map<Patient>(patientToUpdate);

            _context.Patients.Update(patient);
            _context.SaveChanges();
        }

        public void DeletePatient(int id)
        {
            var patient = _context.Patients.FirstOrDefault(d => d.Id == id);

            if(patient is not null)
            {
                _context.Patients.Remove(patient);
                _context.SaveChanges();
            }
        }
    }
}
