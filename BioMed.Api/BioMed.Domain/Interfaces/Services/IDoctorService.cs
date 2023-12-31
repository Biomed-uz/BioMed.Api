using BioMed.Domain.DTOs.Doctor;
using BioMed.Domain.Pagination;
using BioMed.Domain.ResourceParameters;

namespace BioMed.Domain.Interfaces.Services
{
    public interface IDoctorService
    {
        PaginatedList<DoctorDto> GetDoctors(DoctorResourceParameters doctorResourceParameters);
        DoctorDto? GetDoctorById(int id);
        DoctorDto CreateDoctor(DoctorForCreateDto doctorToCreate);
        void UpdateDoctor(DoctorForUpdateDto doctorToUpdate);
        void DeleteDoctor(int id);
    }
}
