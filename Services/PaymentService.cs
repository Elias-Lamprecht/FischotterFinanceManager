using FischotterFinanceManager.Models;

namespace FischotterFinanceManager.Services;

public class PaymentService
{
    #region properties

    public List<Payment> Payments { get; private init; } = [];

    #endregion properties

    #region methods

    public Payment CreatePayment(Guid id, string title, string description, decimal amount)
    {
        Payment payment = new(id, title, description, amount);
        Payments.Add(payment);
        return payment;
    }

    public void DeletePayment(Payment payment)
    {
        Payments.Remove(payment);
    } 

    #endregion methods
}
