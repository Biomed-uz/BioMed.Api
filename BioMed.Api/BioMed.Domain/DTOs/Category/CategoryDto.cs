using BioMed.Domain.DTOs.DoctorCategory;

namespace BioMed.Domain.DTOs.Category
{
    public record CategoryDto(
        int Id,
        string Name,
        ICollection<DoctorCategoryDto> DoctorCategories);
}
