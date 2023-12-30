namespace BioMed.Domain.DTOs.Visit
{
    public record VisitForCreateDto(
        DateTime VisitDate,
         string Prescription,
         decimal TotalPrice,
         int PatientId,
         int DoctorId);
}
