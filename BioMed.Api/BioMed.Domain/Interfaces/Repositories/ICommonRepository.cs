namespace BioMed.Domain.Interfaces.Repositories
{
    public interface ICommonRepository
    {
        public ICategoryRepository Category { get; }
        public IDepartmentRepository Department { get; }
        public IDoctorRepository Doctor { get; }
        public IDoctorCategoryRepository DoctorCategory { get; }
        public IDoctorDepartmentRepository DoctorDepartment { get; }
        public IPatientRepository Patient { get; }
        public IVisitRepostory Visit {  get; }
        public IPaymentRepository Payment { get; }
        public ITestTypeRepository TestType { get; }
        public ILabResultRepository LabResult { get; }
        public IDiseaseCategoryRepository DiseaseCategory { get; }
        public IDiseaseRepository Disease { get; }
        public ITreatmentRepository Treatment { get; }

        public int SaveChanges();
    }
}
