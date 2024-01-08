using BioMed.Domain.Interfaces.Repositories;
using BioMed.Infrastructure.Persistence.Repositories;

namespace BioMed.Api.Extensions
{
    public static class ConfigureServicesExtensions
    {
        public static IServiceCollection ConfigureRepositories(this IServiceCollection services)
        {
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IDepartmentRepository, DepartmentRepository>();
            services.AddScoped<IPatientRepository, PatientRepository>();
            services.AddScoped<IDoctorRepository, DoctorRepository>();
            services.AddScoped<IDoctorCategoryRepository, DoctorCategoryRepository>();
            services.AddScoped<IDoctorDepartmentRepository, DoctorDepartmentRepository>();
            services.AddScoped<IVisitRepostory, VisitRepository>();
            services.AddScoped<IPaymentRepository, PaymentRepository>();
            services.AddScoped<ITestTypeRepository, TestTypeRepository>();
            services.AddScoped<ILabResultRepository, LabResultRepository>();
            services.AddScoped<IDiseaseCategoryRepository, IDiseaseCategoryRepository>();
            services.AddScoped<IDiseaseRepository, IDiseaseRepository>();
            services.AddScoped<ITreatmentRepository, TreatmentRepository>();

            return services;
        }
    }
}
