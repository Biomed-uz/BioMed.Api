namespace BioMed.Domain.DTOs.Doctor
{
    public record DoctorForCreateDto(
        string FullName,
        string PhoneNumber,
        string Email,
        decimal PricePerVisit);
}
