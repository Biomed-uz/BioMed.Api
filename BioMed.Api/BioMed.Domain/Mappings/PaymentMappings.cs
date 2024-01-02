using AutoMapper;
using BioMed.Domain.DTOs.Payment;
using BioMed.Domain.Entities;

namespace BioMed.Domain.Mappings
{
    internal class PaymentMappings : Profile
    {
        public PaymentMappings() 
        {
            CreateMap<Payment, PaymentDto>();
            CreateMap<PaymentDto, Payment>();
            CreateMap<PaymentForCreateDto, Payment>();
            CreateMap<PaymentForUpdateDto, Payment>();
        }
    }
}
