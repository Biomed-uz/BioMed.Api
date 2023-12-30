namespace BioMed.Domain.DTOs.Treatment
{
    public record TreatmentForUpdateDto(
        int Id,
        string Prescription,
        int VisitId,
        int LabResultId,
        int DiseaseId);
}
