namespace BioMed.Domain.DTOs.Treatment
{
    public record TreatmentForCreateDto(
        string Prescription,
        int VisitId,
        int LabResultId,
        int DiseaseId);
}
