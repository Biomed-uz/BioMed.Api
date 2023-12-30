namespace BioMed.Domain.DTOs.Doctor
{
    public record DoctorForUpdateDto(
        int Id,
        string FullName,
        string PhoneNumber,
        string Email,
        decimal PricePerVisit);
}
