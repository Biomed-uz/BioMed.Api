namespace BioMed.Domain.DTOs.Treatment
{
    public record TreatmentDto(
        int Id,
        string Prescription,
        int VisitId,
        int LabResultId,
        int DiseaseId);
}
