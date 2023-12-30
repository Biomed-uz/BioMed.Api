using BioMed.Domain.DTOs.Visit;

namespace BioMed.Domain.DTOs.Patient
{
    public record PatientDto(
         int Id,
         string FirstName,
         string LastName,
         string MiddleName,
         string PhoneNumber,
         string Email,
         DateTime RegistrationDate,
         string Gender,
         ICollection<VisitDto> Visits);
}
