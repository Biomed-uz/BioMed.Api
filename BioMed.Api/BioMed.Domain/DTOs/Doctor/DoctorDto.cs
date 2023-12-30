using BioMed.Domain.DTOs.DoctorCategory;
using BioMed.Domain.DTOs.DoctorDepartment;
using BioMed.Domain.DTOs.Visit;

namespace BioMed.Domain.DTOs.Doctor
{
    public record DoctorDto(
        int Id,
        string FullName,
        string PhoneNumber,
        string Email,
        decimal PricePerVisit,
        ICollection<VisitDto>? Visits,
        ICollection<DoctorDepartmentDto>? DoctorDepartments,
        ICollection<DoctorCategoryDto>? DoctorCategories);
}
