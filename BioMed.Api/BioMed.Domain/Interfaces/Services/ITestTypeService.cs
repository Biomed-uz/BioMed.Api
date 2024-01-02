using BioMed.Domain.DTOs.TestType;
using BioMed.Domain.Pagination;
using BioMed.Domain.ResourceParameters;

namespace BioMed.Domain.Interfaces.Services
{
    public interface ITestTypeService
    {
        PaginatedList<TestTypeDto> GetTestTypes(TestTypeResourceParameters testTypeResourceParameters);
        TestTypeDto? GetvById(int id);
        TestTypeDto CreateTestType(TestTypeForCreateDto testTypeToCreate);
        void UpdateTestType(TestTypeForUpdateDto testTypeToUpdate);
        void DeleteTestType(int id);
    }
}
