namespace BioMed.Domain.DTOs.Payment
{
    public record PaymentForCreateDto(
        decimal Amount,
        DateTime Date,
        int VisitId);
}
