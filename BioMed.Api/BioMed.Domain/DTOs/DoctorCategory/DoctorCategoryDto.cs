namespace BioMed.Domain.DTOs.DoctorCategory
{
    public record DoctorCategoryDto(
        int Id,
        int DoctorId,
        int CategoryId);
}
