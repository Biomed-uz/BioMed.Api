using AutoMapper;
using BioMed.Domain.DTOs.Patient;
using BioMed.Domain.DTOs.Payment;
using BioMed.Domain.Entities;
using BioMed.Domain.Interfaces.Services;
using BioMed.Domain.Pagination;
using BioMed.Domain.ResourceParameters;
using BioMed.Infrastructure.Persistence;

namespace BioMed.Services.Services
{
    public class PaymentService : IPaymentService
    {
        private readonly IMapper _mapper;
        private readonly BioMedDbContext _context;

        public PaymentService(IMapper mapper, BioMedDbContext context)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public PaginatedList<PaymentDto> GetPayments(
            PaymentResourceParameters paymentResourceParameters)
        {
            var query = _context.Payments.AsQueryable();

            if (!string.IsNullOrWhiteSpace(paymentResourceParameters.OrderBy))
            {
                query = paymentResourceParameters.OrderBy.ToLowerInvariant() switch
                {
                    "amount" => query.OrderBy(x => x.Amount),
                    "amountDesc" => query.OrderByDescending(x => x.Amount),
                    "Date" => query.OrderBy(x => x.Date),
                    "DateDesc" => query.OrderByDescending(x => x.Date),
                    "visitId" => query.OrderBy(x => x.VisitId),
                    "visitIdDesc" => query.OrderByDescending(x => x.VisitId),
                    _ => query.OrderBy(x => x.Date)
                };
            }

            var payments = query.ToPaginatedList(paymentResourceParameters.PageSize,
                paymentResourceParameters.PageNumber);
            var paymentsDtos = _mapper.Map<List<PaymentDto>>(payments);

            return new PaginatedList<PaymentDto>(paymentsDtos,
                payments.TotalPages,
                payments.CurrentPage,
                payments.PageSize);
        }

        public PaymentDto? GetPaymentById(int id)
        {
            var payment = _context.Payments.FirstOrDefault(x => x.Id == id);
            
            return _mapper.Map<PaymentDto>(payment);
        }

        public PaymentDto CreatePayment(PaymentForCreateDto paymentToCreate)
        {
            var payment = _mapper.Map<Payment>(paymentToCreate);

            _context.Payments.Add(payment);
            _context.SaveChanges();

            return _mapper.Map<PaymentDto>(payment);
        }

        public void UpdatePayment(PaymentForUpdateDto paymentToUpdate)
        {
            var payment = _mapper.Map<Payment>(paymentToUpdate);

            _context.Payments.Update(payment);
            _context.SaveChanges();
        }

        public void DeletePayment(int id)
        {
            var payment = _context.Payments.FirstOrDefault(x => x.Id == id);

            if(payment is not null)
            {
                _context.Payments.Remove(payment);
                _context.SaveChanges();
            }
        }
    }
}
