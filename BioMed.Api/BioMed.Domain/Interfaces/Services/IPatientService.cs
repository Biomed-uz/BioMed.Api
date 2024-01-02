using BioMed.Domain.DTOs.Patient;
using BioMed.Domain.Pagination;
using BioMed.Domain.ResourceParameters;

namespace BioMed.Domain.Interfaces.Services
{
    public interface IPatientService
    {
        PaginatedList<PatientDto> GetPatients(PatientResourceParameters patientResourceParameters);
        PatientDto? GetPatientById(int id);
        PatientDto CreatePatient(PatientForCreateDto patientToCreate);
        void UpdatePatient(PatientForUpdateDto patientToUpdate);
        void DeletePatient(int id);
    }
}
