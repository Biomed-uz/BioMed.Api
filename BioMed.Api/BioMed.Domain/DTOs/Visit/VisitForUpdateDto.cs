namespace BioMed.Domain.DTOs.Visit
{
    public record VisitForUpdateDto(
        int Id,
        DateTime VisitDate,
        string Prescription,
        decimal TotalPrice,
        int PatientId,
        int DoctorId);
}
