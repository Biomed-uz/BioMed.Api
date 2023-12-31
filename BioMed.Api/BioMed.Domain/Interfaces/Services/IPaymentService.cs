using BioMed.Domain.DTOs.Payment;
using BioMed.Domain.Pagination;
using BioMed.Domain.ResourceParameters;

namespace BioMed.Domain.Interfaces.Services
{
    public interface IPaymentService
    {
        PaginatedList<PaymentDto> GetPayments(PaymentResourceParameters paymentResourceParameters);
        PaymentDto? GetPaymentById(int id);
        PaymentDto CreatePayment(PaymentForCreateDto paymentToCreate);
        void UpdatePayment(PaymentForUpdateDto paymentToUpdate);
        void DeletePayment(int id);
    }
}
