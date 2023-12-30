namespace BioMed.Domain.DTOs.DoctorCategory
{
    public record DoctorCategoryForUpdateDto(
        int Id,
        int DoctorId,
        int CategoryId);
}
